using System;
using System.IO;
using ShrineFox.IO;
using MetroSet_UI.Forms;
using BezelEngineArchive_Lib;
using CLMS;
using System.Linq;
using System.Windows.Forms;
using FirstPlugin;
using SarcLibrary;
using BntxLibrary;
using Revrs;

namespace JamboreeCharaTool
{
    public partial class MainForm : MetroSetForm
    {
        private void ImportFromGameFolder()
        {
            string folder = WinFormsDialogs.SelectFolder("Select Folder to Import");
            if (!Directory.Exists(folder))
                return;

            // Use existing project's character data as a base
            CharaData[] importedCharaData = project.Characters.Copy();

            ImportCharacterNames(folder, importedCharaData);
            ImportProfilePics(folder, importedCharaData);

            ChooseCharactersToImport(importedCharaData);
        }

        private void ImportProfilePics(string folder, CharaData[] importedCharaData)
        {
            throw new NotImplementedException();
        }

        private void ImportCharacterNames(string folder, CharaData[] importedCharaData)
        {
            foreach (var file in Directory.GetFiles(folder).Where(x => Path.GetFileName(x).StartsWith("nq.nx")))
            {
                // Extract images from BEA
                using (FileStream fs = new FileStream(file, FileMode.Open))
                {
                    BezelEngineArchive bea = new BezelEngineArchive(fs);
                    
                    foreach (var archiveFile in bea.FileList.Where(x => x.Key == "Parts.lyt"))
                    {
                        
                        // Extract image data from SARC

                        var bytes = archiveFile.Value.FileData;

                        Sarc sarc = Sarc.FromBinary(bytes);
                        ReadOnlySpan<byte> bntxData = sarc["timg/__Combined.bntx"];
                        Stream stream = new MemoryStream(bntxData.ToArray());

                        RevrsReader reader = new(bntxData.ToArray());
                        BntxView bntx = new(ref reader);

                        foreach ((var name, var tex) in bntx)
                        {
                            bntx.
                        }
                }
            }
        }

        private void ChooseCharactersToImport(CharaData[] importedCharaData)
        {
            for (int i = 0; i < project.Characters.Length; i++)
            {
                var ogChar = project.Characters[i];
                foreach (var newChar in importedCharaData.Where(x => x.ID == ogChar.ID))
                {
                    if (newChar != ogChar)
                    {
                        if (WinFormsDialogs.ShowMessageBox("Replace Character?",
                            $"Replace data for the following character?\n{ogChar.Name_enUS} ==> {newChar.Name_enUS}", MessageBoxButtons.YesNo))
                        {
                            project.Characters[i] = newChar;
                        }
                    }

                }
            }
        }

        private void ExportMod()
        {
            string folder = WinFormsDialogs.SelectFolder("Choose Folder to Output Mod");
            if (!Directory.Exists(folder))
                return;

            ExportCharacterNames(folder);

            MessageBox.Show("Done exporting mod!");
        }

        private void ExportCharacterNames(string folder)
        {
            // For each language's message BEA file...
            foreach (var file in Directory.GetFiles(Path.Combine(extractedRomfsDir, "Archive")).Where(x => Path.GetFileName(x).StartsWith("message~")))
            {
                string language = Path.GetFileNameWithoutExtension(file).Replace("message~", "").Replace(".nx", "");

                // Extract MSBT from BEA
                using (FileStream fs = new FileStream(file, FileMode.Open))
                {
                    BezelEngineArchive bea = new BezelEngineArchive(fs);

                    foreach (var archiveFile in bea.FileList)
                    {
                        // Extract im_common.msbt
                        if (archiveFile.Key.Contains("im_common"))
                        {
                            var bytes = archiveFile.Value.FileData;

                            // Convert to YAML
                            var decompressedBytes = new Zstd().Decompress(bytes);
                            MSBP msbp = new MSBP(File.ReadAllBytes("./Dependencies/bq.msbp"));
                            MSBT msbt = new MSBT(decompressedBytes);
                            msbt.SizePerAttribute = 15; // this is 19 by default for some reason??
                            var yamlLines = msbt.ToYaml(msbp).Split('\n');

                            // Update Names
                            for (int i = 0; i < yamlLines.Length; i++)
                            {
                                if (yamlLines[i].StartsWith("  im_pc"))
                                {
                                    int id = Convert.ToInt32(yamlLines[i].Replace("  im_pc", "").Split('_')[0]);
                                    var character = project.Characters.First(x => x.ID == id);
                                    var newName = GetCharacterName(character, language);
                                    yamlLines[i + 1] = $"    Contents: {newName}\r";
                                }
                            }

                            // Convert back to MSBT
                            string yamlTxt = string.Join('\n', yamlLines);
                            File.WriteAllText("msbt.yaml", yamlTxt);
                            MSBT newMsbt = MSBT.FromYaml(yamlTxt, msbp);

                            // Compress MSBT and replace OG file in BEA
                            var zstdMsbt = new Zstd().Compress(newMsbt.Save());
                            archiveFile.Value.FileData = zstdMsbt.ToArray();
                        }
                    }
                    string outDir = Path.Combine(folder, "Archive");
                    Directory.CreateDirectory(outDir);
                    bea.Save(Path.Combine(outDir, Path.GetFileName(file)));
                }
            }
        }
    }
}