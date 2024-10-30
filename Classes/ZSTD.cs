using CommunityToolkit.HighPerformance.Buffers;
using FlatBuffers.TRPAK;
using Revrs;
using Revrs.Extensions;
using SarcLibrary;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.IO;
using ZstdSharp;

namespace JamboreeCharaTool
{
    public class Zstd
    {
        public static Zstd Shared { get; } = new();

        public const uint MAGIC = 0xFD2FB528;
        public const uint DICT_MAGIC = 0xEC30A437;
        private const uint SARC_MAGIC = 0x43524153;

        private readonly Decompressor _defaultDecompressor = new();
        private readonly Dictionary<int, Decompressor> _decompressors = [];
        private readonly Compressor _defaultCompressor;
        private readonly Dictionary<int, Compressor> _compressors = [];

        private int _compressionLevel = 7;
        public int CompressionLevel
        {
            get => _compressionLevel;
            set
            {
                _compressionLevel = value;
                _defaultCompressor.Level = _compressionLevel;

                foreach ((int _, Compressor compressor) in _compressors)
                {
                    compressor.Level = value;
                }
            }
        }

        public Zstd()
        {
            _defaultCompressor = new Compressor(CompressionLevel);
        }

        public byte[] Decompress(ReadOnlySpan<byte> data)
        {
            return Decompress(data, out _);
        }

        public byte[] Decompress(ReadOnlySpan<byte> data, out int zsDictionaryId)
        {
            int size = GetDecompressedSize(data);
            byte[] result = new byte[size];
            Decompress(data, result, out zsDictionaryId);
            return result;
        }

        public void Decompress(ReadOnlySpan<byte> data, Span<byte> dst)
        {
            Decompress(data, dst, out _);
        }

        public void Decompress(ReadOnlySpan<byte> data, Span<byte> dst, out int zsDictionaryId)
        {
            if (!IsCompressed(data))
            {
                zsDictionaryId = -1;
                return;
            }

            zsDictionaryId = GetDictionaryId(data);
            if (_decompressors.TryGetValue(zsDictionaryId, out Decompressor? decompressor))
            {
                lock (_decompressors)
                {
                    decompressor.Unwrap(data, dst);
                }

                return;
            }

            lock (_defaultDecompressor)
            {
                _defaultDecompressor.Unwrap(data, dst);
            }
        }

        public ArraySegment<byte> Compress(ReadOnlySpan<byte> data, int zsDictionaryId = -1)
        {
            int bounds = Compressor.GetCompressBound(data.Length);
            byte[] result = new byte[bounds];
            int size = Compress(data, result, zsDictionaryId);
            return new ArraySegment<byte>(result, 0, size);
        }

        public int Compress(ReadOnlySpan<byte> data, Span<byte> dst, int zsDictionaryId = -1)
        {
            return _compressors.TryGetValue(zsDictionaryId, out Compressor? compressor) switch
            {
                true => compressor.Wrap(data, dst),
                false => _defaultCompressor.Wrap(data, dst)
            };
        }

        public void LoadDictionaries(string file)
        {
            using FileStream fs = System.IO.File.OpenRead(file);
            int size = Convert.ToInt32(fs.Length);
            using SpanOwner<byte> buffer = SpanOwner<byte>.Allocate(size);
            _ = fs.Read(buffer.Span);
            LoadDictionaries(buffer.Span);
        }

        public void LoadDictionaries(Span<byte> data)
        {
            byte[]? decompressedBuffer = null;

            if (IsCompressed(data))
            {
                int decompressedSize = GetDecompressedSize(data);
                decompressedBuffer = ArrayPool<byte>.Shared.Rent(decompressedSize);
                Span<byte> decompressed = decompressedBuffer.AsSpan()[..decompressedSize];
                Decompress(data, decompressed);
                data = decompressed;
            }

            if (TryLoadDictionary(data))
            {
                return;
            }

            if (data.Length < 8 || data.Read<uint>() != SARC_MAGIC)
            {
                return;
            }

            RevrsReader reader = new(data);
            ImmutableSarc sarc = new(ref reader);
            foreach ((string _, Span<byte> sarcFileData) in sarc)
            {
                TryLoadDictionary(sarcFileData);
            }

            if (decompressedBuffer is not null)
            {
                ArrayPool<byte>.Shared.Return(decompressedBuffer);
            }
        }

        private bool TryLoadDictionary(ReadOnlySpan<byte> buffer)
        {
            if (buffer.Length < 8 || buffer.Read<uint>() != DICT_MAGIC)
            {
                return false;
            }

            Decompressor decompressor = new();
            decompressor.LoadDictionary(buffer);
            _decompressors[buffer[4..8].Read<int>()] = decompressor;

            Compressor compressor = new(CompressionLevel);
            compressor.LoadDictionary(buffer);
            _compressors[buffer[4..8].Read<int>()] = compressor;

            return true;
        }

        public static bool IsCompressed(ReadOnlySpan<byte> data)
        {
            return data.Length > 3 && data.Read<uint>() == MAGIC;
        }

        public static int GetDecompressedSize(Stream stream)
        {
            Span<byte> header = stackalloc byte[14];
            _ = stream.Read(header);
            return GetFrameContentSize(header);
        }

        public static int GetDecompressedSize(ReadOnlySpan<byte> data)
        {
            return GetFrameContentSize(data);
        }

        public static int GetDictionaryId(ReadOnlySpan<byte> buffer)
        {
            byte descriptor = buffer[4];
            int windowDescriptorSize = ((descriptor & 0b00100000) >> 5) ^ 0b1;
            int dictionaryIdFlag = descriptor & 0b00000011;

            return dictionaryIdFlag switch
            {
                0x0 => -1,
                0x1 => buffer[5 + windowDescriptorSize],
                0x2 => buffer[(5 + windowDescriptorSize)..].Read<ushort>(),
                0x3 => buffer[(5 + windowDescriptorSize)..].Read<int>(),
                _ => throw new OverflowException(
                    "Two bits cannot exceed 0x3, something terrible has happened!")
            };
        }

        private static int GetFrameContentSize(ReadOnlySpan<byte> buffer)
        {
            byte descriptor = buffer[4];
            int windowDescriptorSize = ((descriptor & 0b00100000) >> 5) ^ 0b1;
            int dictionaryIdFlag = descriptor & 0b00000011;
            int frameContentFlag = descriptor >> 6;

            int offset = dictionaryIdFlag switch
            {
                0x0 => 5 + windowDescriptorSize,
                0x1 => 5 + windowDescriptorSize + 1,
                0x2 => 5 + windowDescriptorSize + 2,
                0x3 => 5 + windowDescriptorSize + 4,
                _ => throw new OverflowException(
                    "Two bits cannot exceed 0x3, something terrible has happened!")
            };

            return frameContentFlag switch
            {
                0x0 => buffer[offset],
                0x1 => buffer[offset..].Read<ushort>() + 0x100,
                0x2 => buffer[offset..].Read<int>(),
                _ => throw new NotSupportedException(
                    "64-bit file sizes are not supported.")
            };
        }
    }
}
