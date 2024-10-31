﻿using System;
using System.Collections.Generic;
using System.IO;
using ShrineFox.IO;
using MetroSet_UI.Forms;
using BezelEngineArchive_Lib;
using CLMS;
using System.Linq;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Drawing;

namespace JamboreeCharaTool
{
    public partial class MainForm : MetroSetForm
    {
        public MainForm()
        {
            InitializeComponent();
            
            string defaultProjPath = "./Dependencies/Default/DefaultProject.json";
            if (File.Exists(defaultProjPath))
            {
                project = JsonConvert.DeserializeObject<Project>(File.ReadAllText(defaultProjPath));
            }

            PopulateForm();
        }

        private void PopulateForm()
        {
            // Overview
            int column = 0;
            int row = 0;
            foreach (var character in project.Characters)
            {
                Image profilePic = Image.FromFile(character.ProfileIcon_Path);
                PictureBox pictureBox = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };
                pictureBox.Name = $"pictureBox_pc{character.ID:XX)}";
                pictureBox.Click += PictureBox_Click;
                pictureBox.Image = profilePic;

                Label lbl = new Label() { Dock = DockStyle.Fill };
                lbl.Name = $"lbl_pc{character.ID:XX)}";
                lbl.Text = character.Name_enUS;

                TableLayoutPanel tlp = new TableLayoutPanel() { Dock = DockStyle.Fill };
                tlp.Name = $"tlp_pc{character.ID:XX}";
                tlp.RowCount = 2;
                tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
                tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));

                tlp.Controls.Add(pictureBox, 0, 0);
                tlp.Controls.Add(lbl, 0, 1);
                tlp_Overview.Controls.Add(tlp, column, row);

                column++;
                if (column >= 6)
                {
                    column = 0;
                    row++;
                }
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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

            // Use existing project's character data as a base
            CharaData[] importedCharaData = project.Characters.Copy();

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