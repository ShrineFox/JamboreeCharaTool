using MetroSet_UI.Forms;
using Newtonsoft.Json;
using ShrineFox.IO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JamboreeCharaTool
{
    public partial class MainForm : MetroSetForm
    {
        // Initialization

        BindingSource bs_Languages = new BindingSource();
        BindingSource bs_Character = new BindingSource();

        public MainForm()
        {
            InitializeComponent();

            projectPath = "./Dependencies/Default/DefaultProject.json";
            if (File.Exists(projectPath))
            {
                project = JsonConvert.DeserializeObject<Project>(File.ReadAllText(projectPath));
            }

#if DEBUG
            extractedRomfsDir = "D:\\_Projects\\JAMBOREE\\romfs";
            exportModToolStripMenuItem.Enabled = true;
#endif
            SetBindings();
            PopulateForm();
        }

        private void SetBindings()
        {
            // Language Selection
            bs_Languages.DataSource = languages;
            comboBox_Language.ComboBox.DataSource = bs_Languages;
            comboBox_Language.ComboBox.FormattingEnabled = true;
            comboBox_Language.ComboBox.Format += LanguageFormat;

            // Character Selection
            bs_Character.DataSource = project.Characters;
            comboBox_Character.ComboBox.DataSource = bs_Character;
            comboBox_Character.ComboBox.FormattingEnabled = true;
            comboBox_Character.ComboBox.Format += CharacterFormat;
        }

        private void PopulateForm()
        {
            // Overview
            int column = 0;
            int row = 0;
            foreach (var character in project.Characters)
            {
                Image profilePic = Image.FromFile(Path.Combine(Path.GetDirectoryName(projectPath), character.ProfileIcon_Path));
                PictureBox pictureBox = new PictureBox() { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };
                pictureBox.Name = $"pictureBox_pc{character.ID.ToString("00")}";
                pictureBox.Click += PictureBox_Click;
                pictureBox.Image = profilePic;

                Label lbl = new Label() { Dock = DockStyle.Fill };
                lbl.Name = $"lbl_pc{character.ID.ToString("00")}";
                lbl.Text = character.Name_enUS;

                TableLayoutPanel tlp = new TableLayoutPanel() { Dock = DockStyle.Fill };
                tlp.Name = $"tlp_pc{character.ID.ToString("00")}";
                tlp.RowCount = 2;
                tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
                tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
                if (character.ID == 01)
                    tlp.BackColor = Color.DarkBlue;

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

        // File ToolStrip Menu

        private void SaveProject_Click(object sender, EventArgs e)
        {
            SaveProject();
        }

        private void ImportFromFolder_Click(object sender, EventArgs e)
        {
            ImportFromGameFolder();
        }

        private void ExportMod_Click(object sender, EventArgs e)
        {
            ExportMod();
        }

        // Settings ToolStrip Menu

        private void SetExtractedRomFS_Click(object sender, EventArgs e)
        {
            string romfsDir = WinFormsDialogs.SelectFolder("Choose Extracted RomFS Folder");
            if (Directory.GetDirectories(romfsDir).Any(x => Path.GetFileName(x) == "nro"))
            {
                extractedRomfsDir = romfsDir;
                exportModToolStripMenuItem.Enabled = true;
            }
            else
            {
                extractedRomfsDir = "";
                MessageBox.Show("Invalid RomFS directory chosen!");
                exportModToolStripMenuItem.Enabled = false;
            }
        }

        private void SelectedLanguage_Changed(object sender, EventArgs e)
        {
            UpdateTextTab();
            UpdateOverviewTab();
        }

        private void SelectedCharacter_Changed(object sender, EventArgs e)
        {
            UpdateTextTab();
            UpdateOverviewTab();
        }

        private void CharacterFormat(object sender, ListControlConvertEventArgs e)
        {
            CharaData character = (CharaData)e.ListItem;
            e.Value = GetCharacterName(character, GetSelectedLanguage());
        }

        private void LanguageFormat(object sender, ListControlConvertEventArgs e)
        {
            var lang = (Tuple<string, string>)e.ListItem;
            e.Value = lang.Item2;
        }

        // Overview Tab

        private void PictureBox_Click(object sender, EventArgs e)
        {
            var pictureBox = (PictureBox)sender;

            var characterID = Convert.ToInt32(pictureBox.Name.Replace("pictureBox_pc", ""));
            comboBox_Character.SelectedIndex = Array.IndexOf(project.Characters, project.Characters.First(x => x.ID == characterID));
        }

        private void UpdateOverviewTab()
        {
            int charIndex = 0;
            foreach (var tlp in tlp_Overview.GetAllControls<TableLayoutPanel>())
            {
                foreach (var label in tlp.GetAllControls<Label>())
                {
                    // Update character name in Overview tab
                    label.Text = GetCharacterName(project.Characters[charIndex]);
                    // Highlight background of selected character profile pic
                    if (charIndex == comboBox_Character.SelectedIndex)
                        tlp.BackColor = Color.DarkBlue;
                    else
                        tlp.BackColor = Color.Transparent;
                }
                charIndex++;
            }
        }

        // Text Tab

        private void Name_Changed(object sender, EventArgs e)
        {
            if (!txt_Name.Enabled)
                return;

            SetCharacterName(GetSelectedCharacter(), txt_Name.Text, GetSelectedLanguage());
            UpdateOverviewTab();
        }

        private void UpdateTextTab()
        {
            if (comboBox_Character.SelectedItem == null)
                return;

            // Update character name in Text tab
            txt_Name.Enabled = false;
            txt_Name.Text = GetCharacterName(GetSelectedCharacter(), GetSelectedLanguage());
            txt_Name.Enabled = true;
        }
    }
}
