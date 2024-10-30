using System;
using System.Collections.Generic;
using System.IO;
using ShrineFox.IO;
using MetroSet_UI.Forms;
using BezelEngineArchive_Lib;
using MessageStudio.Formats.BinaryText;

namespace JamboreeCharaTool
{
    public partial class MainForm : MetroSetForm
    {
        public Tuple<string,string>[] languages = new Tuple<string,string>[] { 
            new Tuple<string, string>("deEU","German"),
            new Tuple<string, string>("enEU","English (Europe)"),
            new Tuple<string, string>("enUS","English (American)"),
            new Tuple<string, string>("esUS","Spanish (Americas)"),
            new Tuple<string, string>("frCA","French (Canadian)"),
            new Tuple<string, string>("frEU","French (Europe)"),
            new Tuple<string, string>("itEU","Italian"),
            new Tuple<string, string>("jaJP","Japanese"),
            new Tuple<string, string>("korKR","Korean"),
            new Tuple<string, string>("nlEU","Dutch"),
            new Tuple<string, string>("ptBR","Portuguese"),
            new Tuple<string, string>("ruEU","Russian"),
            new Tuple<string, string>("zhCN","Chinese (China)"),
            new Tuple<string, string>("zhTW","Chinese (Taiwan)")
        };

        public class Project
        {
            List<CharaData> Characters { get; set; } = new List<CharaData>();
        }

        public class CharaData
        {
            public int ID { get; set; } = 0;
            public string Name_deEU { get; set; } = "Dummy";
            public string Name_enEU { get; set; } = "Dummy";
            public string Name_enUS { get; set; } = "Dummy";
            public string Name_esUS { get; set; } = "Dummy";
            public string Name_frCA { get; set; } = "Dummy";
            public string Name_frEU { get; set; } = "Dummy";
            public string Name_itEU { get; set; } = "Dummy";
            public string Name_jaJP { get; set; } = "Dummy";
            public string Name_korKR { get; set; } = "Dummy";
            public string Name_nlEU { get; set; } = "Dummy";
            public string Name_ptBR { get; set; } = "Dummy";
            public string Name_ruEU { get; set; } = "Dummy";
            public string Name_zhCN { get; set; } = "Dummy";
            public string Name_zhTW { get; set; } = "Dummy";
            public string ProfileIcon_Path { get; set; } = "./Dependencies/Default/face_256_pc/face_256_pc01^u.png";
            public string ProfileIcon_Npc_Path { get; set; } = "./Dependencies/Default/face_256_npc/face_256_npc901^u.png";
            public string MapIcon_Path { get; set; } = "./Dependencies/Default/face_front128/face_128_pc01^u.png";
        }

        public MainForm()
        {
            InitializeComponent();
            CreateDefaultProject();
        }

        private void CreateDefaultProject()
        {
        }

        private void SetupTheme()
        {
            Theme.ThemeStyle = MetroSet_UI.Enums.Style.Dark;
            Theme.ApplyToForm(this);
        }

        private void SetupLogging()
        {
            Output.Logging = true;
#if DEBUG
            Output.VerboseLogging = true;
            Output.LogControl = rtb_Log;
#endif
        }

        private void ImportFromFolder_Click(object sender, EventArgs e)
        {
            string folder = WinFormsDialogs.SelectFolder("Select Folder to Import");
            if (!Directory.Exists(folder))
                return;

            List<CharaData> importedCharaData = new List<CharaData>();

            foreach (var file in Directory.GetFiles(folder))
            {
                // Character Names MSBTs
                if (Path.GetFileName(file).StartsWith("message~"))
                {
                    foreach (var language in languages)
                    {
                        string beaFile = $"message~{language.Item1}.nx.bea";
                        if (Path.GetFileName(file) == beaFile)
                        {
                            // Extract MSBT from BEA
                            using (FileStream fs = new FileStream(file, FileMode.Open))
                            {
                                BezelEngineArchive bea = new BezelEngineArchive(fs);
                                foreach(var archiveFile in bea.FileList)
                                {
                                    // Extract im_common.msbt
                                    if (archiveFile.Key.Contains("im_common"))
                                    {
                                        var bytes = archiveFile.Value.FileData;

                                        // Convert to YAML
                                        var decompressedBytes = new Zstd().Decompress(bytes);
                                        var msbt = Msbt.FromBinary(decompressedBytes);
                                        string yaml = msbt.ToYaml();
                                        File.WriteAllText($"im_common_{language.Item1}.yml", yaml);
                                    }
                                }
                            }
                        }
                    }
                }

            }
            
        }
    }
}