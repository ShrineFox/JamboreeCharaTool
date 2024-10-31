using MetroSet_UI.Forms;
using Newtonsoft.Json;
using ShrineFox.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JamboreeCharaTool
{
    public partial class MainForm : MetroSetForm
    {
        public static Project project = new Project();

        public Tuple<string, string>[] languages = new Tuple<string, string>[] {
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
            public CharaData[] Characters { get; set; }
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

        private void SaveProject()
        {
            // Get output path from file select prompt
            var outPaths = WinFormsDialogs.SelectFile("Save Project...", true, new string[] { "Project JSON (.json)" }, true);
            if (outPaths == null || outPaths.Count == 0 || string.IsNullOrEmpty(outPaths.First()))
                return;

            // Ensure output path ends with .json
            string outPath = outPaths.First();
            if (!outPath.ToLower().EndsWith(".json"))
                outPath += ".json";

            // Save to .json file
            File.WriteAllText(outPaths[0], JsonConvert.SerializeObject(project, Formatting.Indented));
            MessageBox.Show($"Saved project file to:\n{outPaths[0]}", "Project Saved");
        }
    }
}
