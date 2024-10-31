using System;
using System.Collections.Generic;
using System.IO;
using ShrineFox.IO;
using MetroSet_UI.Forms;
using BezelEngineArchive_Lib;
using CLMS;
using System.Linq;
using Newtonsoft.Json;

namespace JamboreeCharaTool
{
    public partial class MainForm : MetroSetForm
    {

        public static Project project = new Project();

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
            public CharaData[] Characters { get; set; } = DefaultCharacters.Copy();
        }

        public static CharaData[] DefaultCharacters =
        {
            new CharaData() { ID = 1, Name_enUS = "Mario" },
            new CharaData() { ID = 2, Name_enUS = "Luigi" },
            new CharaData() { ID = 3, Name_enUS = "Peach" },
            new CharaData() { ID = 4, Name_enUS = "Daisy" },
            new CharaData() { ID = 5, Name_enUS = "Wario" },
            new CharaData() { ID = 6, Name_enUS = "Waluigi" },
            new CharaData() { ID = 7, Name_enUS = "Yoshi" },
            new CharaData() { ID = 8, Name_enUS = "Toadette" },
            new CharaData() { ID = 9, Name_enUS = "Toad" },
            new CharaData() { ID = 11, Name_enUS = "Rosalina" },
            new CharaData() { ID = 12, Name_enUS = "Donkey Kong" },
            new CharaData() { ID = 13, Name_enUS = "Birdo" },
            new CharaData() { ID = 14, Name_enUS = "Pauline" },
            new CharaData() { ID = 50, Name_enUS = "Bowser" },
            new CharaData() { ID = 51, Name_enUS = "Goomba" },
            new CharaData() { ID = 52, Name_enUS = "Shy Guy" },
            new CharaData() { ID = 53, Name_enUS = "Koopa Troopa" },
            new CharaData() { ID = 54, Name_enUS = "Monty Mole" },
            new CharaData() { ID = 56, Name_enUS = "Bowser Jr." },
            new CharaData() { ID = 58, Name_enUS = "Boo" },
            new CharaData() { ID = 61, Name_enUS = "Spike" },
            new CharaData() { ID = 62, Name_enUS = "Ninji" }
        };

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

            CharaData[] importedCharaData = DefaultCharacters.Copy();

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
                                        MSBT msbt = new MSBT(decompressedBytes);
                                        var yamlLines = msbt.ToYaml().Split('\n');
                                        
                                        // Get Names
                                        for (int i = 0; i < yamlLines.Length; i++)
                                        {
                                            if (yamlLines[i].StartsWith("  im_pc"))
                                            {
                                                int id = Convert.ToInt32(yamlLines[i].Replace("  im_pc","").Split('_')[0]);
                                                string name = yamlLines[i + 1].Replace("   Contents: ","").Replace("\r","");

                                                switch(language.Item1)
                                                {
                                                    case "deEU": importedCharaData.First(x => x.ID == id).Name_deEU = name; break;
                                                    case "enEU": importedCharaData.First(x => x.ID == id).Name_enEU = name; break;
                                                    case "enUS": importedCharaData.First(x => x.ID == id).Name_enUS = name; break;
                                                    case "esUS": importedCharaData.First(x => x.ID == id).Name_esUS = name; break;
                                                    case "frCA": importedCharaData.First(x => x.ID == id).Name_frCA = name; break;
                                                    case "frEU": importedCharaData.First(x => x.ID == id).Name_frEU = name; break;
                                                    case "itEU": importedCharaData.First(x => x.ID == id).Name_itEU = name; break;
                                                    case "jaJP": importedCharaData.First(x => x.ID == id).Name_jaJP = name; break;
                                                    case "korKR": importedCharaData.First(x => x.ID == id).Name_korKR = name; break;
                                                    case "nlEU": importedCharaData.First(x => x.ID == id).Name_nlEU = name; break;
                                                    case "ptBR": importedCharaData.First(x => x.ID == id).Name_ptBR = name; break;
                                                    case "ruEU": importedCharaData.First(x => x.ID == id).Name_ruEU = name; break;
                                                    case "zhCN": importedCharaData.First(x => x.ID == id).Name_zhCN = name; break;
                                                    case "zhTW": importedCharaData.First(x => x.ID == id).Name_zhTW = name; break;
                                                    default: break;
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

            project.Characters = importedCharaData;

            File.WriteAllText("out.json", JsonConvert.SerializeObject(project, Formatting.Indented));

            // Decide which data to import
            for (int i = 0; i < project.Characters.Length; i++)
            {
                var ogChar = project.Characters[i];
                foreach (var newChar in importedCharaData.Where(x => x.ID == ogChar.ID))
                {
                    if (newChar != ogChar && WinFormsDialogs.ShowMessageBox("Replace Character?", 
                        $"Replace data for the following character?\n{ogChar.Name_enUS} ==> {newChar.Name_enUS}"))
                    {
                        project.Characters[i] = newChar;
                    }
                }
            }
        }
    }
}