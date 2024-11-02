using MetroSet_UI.Forms;

namespace JamboreeCharaTool
{
    partial class MainForm : MetroSetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            loadProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            fromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            fromFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exportModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            setExtractedRomFSFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            characterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            comboBox_Character = new System.Windows.Forms.ToolStripComboBox();
            languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            comboBox_Language = new System.Windows.Forms.ToolStripComboBox();
            splitContainer_Main = new System.Windows.Forms.SplitContainer();
            metroSetTabControl_Main = new MetroSet_UI.Controls.MetroSetTabControl();
            tabPage_Graphics = new System.Windows.Forms.TabPage();
            tlp_Graphics = new System.Windows.Forms.TableLayoutPanel();
            groupBox_ProfileIcon = new System.Windows.Forms.GroupBox();
            tlp_ProfileIcon = new System.Windows.Forms.TableLayoutPanel();
            pictureBox_ProfileIcon = new System.Windows.Forms.PictureBox();
            txt_ProfileIcon = new System.Windows.Forms.TextBox();
            btn_ProfileIcon = new System.Windows.Forms.Button();
            tabPage_Overview = new System.Windows.Forms.TabPage();
            pnl_Overview = new System.Windows.Forms.Panel();
            tlp_Overview = new System.Windows.Forms.TableLayoutPanel();
            tabPage_Sound = new System.Windows.Forms.TabPage();
            tlp_Sound = new System.Windows.Forms.TableLayoutPanel();
            tabPage_Text = new System.Windows.Forms.TabPage();
            tlp_Text = new System.Windows.Forms.TableLayoutPanel();
            lbl_Name = new System.Windows.Forms.Label();
            txt_Name = new System.Windows.Forms.TextBox();
            rtb_Log = new System.Windows.Forms.RichTextBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer_Main).BeginInit();
            splitContainer_Main.Panel1.SuspendLayout();
            splitContainer_Main.Panel2.SuspendLayout();
            splitContainer_Main.SuspendLayout();
            metroSetTabControl_Main.SuspendLayout();
            tabPage_Graphics.SuspendLayout();
            tlp_Graphics.SuspendLayout();
            groupBox_ProfileIcon.SuspendLayout();
            tlp_ProfileIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_ProfileIcon).BeginInit();
            tabPage_Overview.SuspendLayout();
            pnl_Overview.SuspendLayout();
            tabPage_Sound.SuspendLayout();
            tabPage_Text.SuspendLayout();
            tlp_Text.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AllowDrop = true;
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, settingsToolStripMenuItem, characterToolStripMenuItem, comboBox_Character, languageToolStripMenuItem, comboBox_Language });
            menuStrip1.Location = new System.Drawing.Point(2, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(778, 32);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { loadProjectToolStripMenuItem, saveProjectToolStripMenuItem, importToolStripMenuItem, exportModToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(46, 28);
            fileToolStripMenuItem.Text = "File";
            // 
            // loadProjectToolStripMenuItem
            // 
            loadProjectToolStripMenuItem.Name = "loadProjectToolStripMenuItem";
            loadProjectToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            loadProjectToolStripMenuItem.Text = "Load Project";
            // 
            // saveProjectToolStripMenuItem
            // 
            saveProjectToolStripMenuItem.Name = "saveProjectToolStripMenuItem";
            saveProjectToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            saveProjectToolStripMenuItem.Text = "Save Project";
            saveProjectToolStripMenuItem.Click += SaveProject_Click;
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { fromFileToolStripMenuItem, fromFolderToolStripMenuItem });
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            importToolStripMenuItem.Text = "Import...";
            // 
            // fromFileToolStripMenuItem
            // 
            fromFileToolStripMenuItem.Name = "fromFileToolStripMenuItem";
            fromFileToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            fromFileToolStripMenuItem.Text = "From File";
            // 
            // fromFolderToolStripMenuItem
            // 
            fromFolderToolStripMenuItem.Name = "fromFolderToolStripMenuItem";
            fromFolderToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            fromFolderToolStripMenuItem.Text = "From Folder";
            fromFolderToolStripMenuItem.Click += ImportFromFolder_Click;
            // 
            // exportModToolStripMenuItem
            // 
            exportModToolStripMenuItem.Enabled = false;
            exportModToolStripMenuItem.Name = "exportModToolStripMenuItem";
            exportModToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            exportModToolStripMenuItem.Text = "Export Mod";
            exportModToolStripMenuItem.Click += ExportMod_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { setExtractedRomFSFolderToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 28);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // setExtractedRomFSFolderToolStripMenuItem
            // 
            setExtractedRomFSFolderToolStripMenuItem.Name = "setExtractedRomFSFolderToolStripMenuItem";
            setExtractedRomFSFolderToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            setExtractedRomFSFolderToolStripMenuItem.Text = "Set Extracted RomFS Folder";
            setExtractedRomFSFolderToolStripMenuItem.Click += SetExtractedRomFS_Click;
            // 
            // characterToolStripMenuItem
            // 
            characterToolStripMenuItem.Enabled = false;
            characterToolStripMenuItem.Name = "characterToolStripMenuItem";
            characterToolStripMenuItem.Size = new System.Drawing.Size(89, 28);
            characterToolStripMenuItem.Text = "Character:";
            // 
            // comboBox_Character
            // 
            comboBox_Character.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox_Character.Items.AddRange(new object[] { "Mario", "Luigi", "Peach", "Daisy", "Wario", "Waluigi", "Yoshi", "Toadette", "Toad", "Rosalina", "Donkey Kong", "Birdo", "Pauline", "Bowser", "Goomba", "Shy Guy", "Koopa Troopa", "Monty Mole", "Bowser Jr.", "Boo", "Spike", "Ninji" });
            comboBox_Character.Name = "comboBox_Character";
            comboBox_Character.Size = new System.Drawing.Size(151, 28);
            comboBox_Character.SelectedIndexChanged += SelectedCharacter_Changed;
            // 
            // languageToolStripMenuItem
            // 
            languageToolStripMenuItem.Enabled = false;
            languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            languageToolStripMenuItem.Size = new System.Drawing.Size(91, 28);
            languageToolStripMenuItem.Text = "Language:";
            // 
            // comboBox_Language
            // 
            comboBox_Language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox_Language.Name = "comboBox_Language";
            comboBox_Language.Size = new System.Drawing.Size(191, 28);
            comboBox_Language.SelectedIndexChanged += this.SelectedLanguage_Changed;
            // 
            // splitContainer_Main
            // 
            splitContainer_Main.AllowDrop = true;
            splitContainer_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer_Main.Location = new System.Drawing.Point(2, 32);
            splitContainer_Main.Name = "splitContainer_Main";
            splitContainer_Main.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_Main.Panel1
            // 
            splitContainer_Main.Panel1.AllowDrop = true;
            splitContainer_Main.Panel1.Controls.Add(metroSetTabControl_Main);
            // 
            // splitContainer_Main.Panel2
            // 
            splitContainer_Main.Panel2.AllowDrop = true;
            splitContainer_Main.Panel2.Controls.Add(rtb_Log);
            splitContainer_Main.Size = new System.Drawing.Size(778, 569);
            splitContainer_Main.SplitterDistance = 504;
            splitContainer_Main.TabIndex = 2;
            // 
            // metroSetTabControl_Main
            // 
            metroSetTabControl_Main.AllowDrop = true;
            metroSetTabControl_Main.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            metroSetTabControl_Main.AnimateTime = 200;
            metroSetTabControl_Main.BackgroundColor = System.Drawing.Color.FromArgb(30, 30, 30);
            metroSetTabControl_Main.Controls.Add(tabPage_Graphics);
            metroSetTabControl_Main.Controls.Add(tabPage_Overview);
            metroSetTabControl_Main.Controls.Add(tabPage_Sound);
            metroSetTabControl_Main.Controls.Add(tabPage_Text);
            metroSetTabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            metroSetTabControl_Main.IsDerivedStyle = true;
            metroSetTabControl_Main.ItemSize = new System.Drawing.Size(100, 38);
            metroSetTabControl_Main.Location = new System.Drawing.Point(0, 0);
            metroSetTabControl_Main.Name = "metroSetTabControl_Main";
            metroSetTabControl_Main.SelectedIndex = 0;
            metroSetTabControl_Main.SelectedTextColor = System.Drawing.Color.White;
            metroSetTabControl_Main.Size = new System.Drawing.Size(778, 504);
            metroSetTabControl_Main.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            metroSetTabControl_Main.Speed = 100;
            metroSetTabControl_Main.Style = MetroSet_UI.Enums.Style.Dark;
            metroSetTabControl_Main.StyleManager = null;
            metroSetTabControl_Main.TabIndex = 2;
            metroSetTabControl_Main.TabStyle = MetroSet_UI.Enums.TabStyle.Style2;
            metroSetTabControl_Main.ThemeAuthor = "Narwin";
            metroSetTabControl_Main.ThemeName = "MetroDark";
            metroSetTabControl_Main.UnselectedTextColor = System.Drawing.Color.Gray;
            metroSetTabControl_Main.UseAnimation = false;
            // 
            // tabPage_Graphics
            // 
            tabPage_Graphics.AllowDrop = true;
            tabPage_Graphics.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            tabPage_Graphics.Controls.Add(tlp_Graphics);
            tabPage_Graphics.Location = new System.Drawing.Point(4, 42);
            tabPage_Graphics.Name = "tabPage_Graphics";
            tabPage_Graphics.Size = new System.Drawing.Size(770, 458);
            tabPage_Graphics.TabIndex = 0;
            tabPage_Graphics.Text = "Graphics";
            // 
            // tlp_Graphics
            // 
            tlp_Graphics.AllowDrop = true;
            tlp_Graphics.ColumnCount = 2;
            tlp_Graphics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlp_Graphics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlp_Graphics.Controls.Add(groupBox_ProfileIcon, 0, 0);
            tlp_Graphics.Dock = System.Windows.Forms.DockStyle.Fill;
            tlp_Graphics.Location = new System.Drawing.Point(0, 0);
            tlp_Graphics.Name = "tlp_Graphics";
            tlp_Graphics.RowCount = 2;
            tlp_Graphics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            tlp_Graphics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            tlp_Graphics.Size = new System.Drawing.Size(770, 458);
            tlp_Graphics.TabIndex = 3;
            // 
            // groupBox_ProfileIcon
            // 
            tlp_Graphics.SetColumnSpan(groupBox_ProfileIcon, 2);
            groupBox_ProfileIcon.Controls.Add(tlp_ProfileIcon);
            groupBox_ProfileIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox_ProfileIcon.ForeColor = System.Drawing.Color.Silver;
            groupBox_ProfileIcon.Location = new System.Drawing.Point(3, 3);
            groupBox_ProfileIcon.Name = "groupBox_ProfileIcon";
            groupBox_ProfileIcon.Size = new System.Drawing.Size(764, 200);
            groupBox_ProfileIcon.TabIndex = 1;
            groupBox_ProfileIcon.TabStop = false;
            groupBox_ProfileIcon.Text = "Profile Icon";
            // 
            // tlp_ProfileIcon
            // 
            tlp_ProfileIcon.ColumnCount = 3;
            tlp_ProfileIcon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlp_ProfileIcon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tlp_ProfileIcon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tlp_ProfileIcon.Controls.Add(pictureBox_ProfileIcon, 0, 0);
            tlp_ProfileIcon.Controls.Add(txt_ProfileIcon, 1, 0);
            tlp_ProfileIcon.Controls.Add(btn_ProfileIcon, 2, 0);
            tlp_ProfileIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            tlp_ProfileIcon.Location = new System.Drawing.Point(3, 28);
            tlp_ProfileIcon.Name = "tlp_ProfileIcon";
            tlp_ProfileIcon.RowCount = 1;
            tlp_ProfileIcon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlp_ProfileIcon.Size = new System.Drawing.Size(758, 169);
            tlp_ProfileIcon.TabIndex = 0;
            // 
            // pictureBox_ProfileIcon
            // 
            pictureBox_ProfileIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            pictureBox_ProfileIcon.Location = new System.Drawing.Point(3, 3);
            pictureBox_ProfileIcon.Name = "pictureBox_ProfileIcon";
            pictureBox_ProfileIcon.Size = new System.Drawing.Size(373, 163);
            pictureBox_ProfileIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox_ProfileIcon.TabIndex = 0;
            pictureBox_ProfileIcon.TabStop = false;
            // 
            // txt_ProfileIcon
            // 
            txt_ProfileIcon.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txt_ProfileIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt_ProfileIcon.Location = new System.Drawing.Point(382, 68);
            txt_ProfileIcon.Name = "txt_ProfileIcon";
            txt_ProfileIcon.Size = new System.Drawing.Size(297, 32);
            txt_ProfileIcon.TabIndex = 1;
            // 
            // btn_ProfileIcon
            // 
            btn_ProfileIcon.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btn_ProfileIcon.Location = new System.Drawing.Point(685, 70);
            btn_ProfileIcon.Name = "btn_ProfileIcon";
            btn_ProfileIcon.Size = new System.Drawing.Size(70, 29);
            btn_ProfileIcon.TabIndex = 2;
            btn_ProfileIcon.Text = "...";
            btn_ProfileIcon.UseVisualStyleBackColor = true;
            // 
            // tabPage_Overview
            // 
            tabPage_Overview.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            tabPage_Overview.Controls.Add(pnl_Overview);
            tabPage_Overview.Location = new System.Drawing.Point(4, 42);
            tabPage_Overview.Name = "tabPage_Overview";
            tabPage_Overview.Size = new System.Drawing.Size(770, 458);
            tabPage_Overview.TabIndex = 3;
            tabPage_Overview.Text = "Overview";
            // 
            // pnl_Overview
            // 
            pnl_Overview.Controls.Add(tlp_Overview);
            pnl_Overview.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl_Overview.Location = new System.Drawing.Point(0, 0);
            pnl_Overview.Name = "pnl_Overview";
            pnl_Overview.Size = new System.Drawing.Size(770, 458);
            pnl_Overview.TabIndex = 0;
            // 
            // tlp_Overview
            // 
            tlp_Overview.AllowDrop = true;
            tlp_Overview.ColumnCount = 6;
            tlp_Overview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.666666F));
            tlp_Overview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.666666F));
            tlp_Overview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.666666F));
            tlp_Overview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.666666F));
            tlp_Overview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.666666F));
            tlp_Overview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.666666F));
            tlp_Overview.Dock = System.Windows.Forms.DockStyle.Fill;
            tlp_Overview.Location = new System.Drawing.Point(0, 0);
            tlp_Overview.Name = "tlp_Overview";
            tlp_Overview.RowCount = 4;
            tlp_Overview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlp_Overview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlp_Overview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlp_Overview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlp_Overview.Size = new System.Drawing.Size(770, 458);
            tlp_Overview.TabIndex = 5;
            // 
            // tabPage_Sound
            // 
            tabPage_Sound.AllowDrop = true;
            tabPage_Sound.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            tabPage_Sound.Controls.Add(tlp_Sound);
            tabPage_Sound.Location = new System.Drawing.Point(4, 42);
            tabPage_Sound.Name = "tabPage_Sound";
            tabPage_Sound.Size = new System.Drawing.Size(770, 458);
            tabPage_Sound.TabIndex = 1;
            tabPage_Sound.Text = "Sound";
            // 
            // tlp_Sound
            // 
            tlp_Sound.AllowDrop = true;
            tlp_Sound.ColumnCount = 2;
            tlp_Sound.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlp_Sound.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlp_Sound.Dock = System.Windows.Forms.DockStyle.Fill;
            tlp_Sound.Location = new System.Drawing.Point(0, 0);
            tlp_Sound.Name = "tlp_Sound";
            tlp_Sound.RowCount = 2;
            tlp_Sound.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            tlp_Sound.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            tlp_Sound.Size = new System.Drawing.Size(770, 458);
            tlp_Sound.TabIndex = 4;
            // 
            // tabPage_Text
            // 
            tabPage_Text.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            tabPage_Text.Controls.Add(tlp_Text);
            tabPage_Text.Location = new System.Drawing.Point(4, 42);
            tabPage_Text.Name = "tabPage_Text";
            tabPage_Text.Size = new System.Drawing.Size(770, 458);
            tabPage_Text.TabIndex = 2;
            tabPage_Text.Text = "Text";
            // 
            // tlp_Text
            // 
            tlp_Text.ColumnCount = 2;
            tlp_Text.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlp_Text.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlp_Text.Controls.Add(lbl_Name, 0, 0);
            tlp_Text.Controls.Add(txt_Name, 1, 0);
            tlp_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            tlp_Text.Location = new System.Drawing.Point(0, 0);
            tlp_Text.Name = "tlp_Text";
            tlp_Text.RowCount = 1;
            tlp_Text.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlp_Text.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlp_Text.Size = new System.Drawing.Size(770, 458);
            tlp_Text.TabIndex = 3;
            // 
            // lbl_Name
            // 
            lbl_Name.Anchor = System.Windows.Forms.AnchorStyles.Right;
            lbl_Name.AutoSize = true;
            lbl_Name.Location = new System.Drawing.Point(204, 216);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new System.Drawing.Size(178, 26);
            lbl_Name.TabIndex = 0;
            lbl_Name.Text = "Character Name:";
            // 
            // txt_Name
            // 
            txt_Name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            txt_Name.Location = new System.Drawing.Point(388, 213);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new System.Drawing.Size(287, 32);
            txt_Name.TabIndex = 1;
            txt_Name.TextChanged += Name_Changed;
            // 
            // rtb_Log
            // 
            rtb_Log.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            rtb_Log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            rtb_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            rtb_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            rtb_Log.ForeColor = System.Drawing.SystemColors.ScrollBar;
            rtb_Log.Location = new System.Drawing.Point(0, 0);
            rtb_Log.Name = "rtb_Log";
            rtb_Log.ReadOnly = true;
            rtb_Log.Size = new System.Drawing.Size(778, 61);
            rtb_Log.TabIndex = 0;
            rtb_Log.Text = "";
            // 
            // MainForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundColor = System.Drawing.Color.FromArgb(30, 30, 30);
            ClientSize = new System.Drawing.Size(782, 603);
            Controls.Add(splitContainer_Main);
            Controls.Add(menuStrip1);
            DropShadowEffect = false;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            HeaderHeight = -40;
            MainMenuStrip = menuStrip1;
            MinimumSize = new System.Drawing.Size(800, 650);
            Name = "MainForm";
            Opacity = 0.99D;
            Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            ShowHeader = true;
            ShowLeftRect = false;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            Style = MetroSet_UI.Enums.Style.Dark;
            Text = "JamboreeCharaTool";
            TextColor = System.Drawing.Color.White;
            ThemeName = "MetroDark";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer_Main.Panel1.ResumeLayout(false);
            splitContainer_Main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer_Main).EndInit();
            splitContainer_Main.ResumeLayout(false);
            metroSetTabControl_Main.ResumeLayout(false);
            tabPage_Graphics.ResumeLayout(false);
            tlp_Graphics.ResumeLayout(false);
            groupBox_ProfileIcon.ResumeLayout(false);
            tlp_ProfileIcon.ResumeLayout(false);
            tlp_ProfileIcon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_ProfileIcon).EndInit();
            tabPage_Overview.ResumeLayout(false);
            pnl_Overview.ResumeLayout(false);
            tabPage_Sound.ResumeLayout(false);
            tabPage_Text.ResumeLayout(false);
            tlp_Text.ResumeLayout(false);
            tlp_Text.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProjectToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer_Main;
        private MetroSet_UI.Controls.MetroSetTabControl metroSetTabControl_Main;
        private System.Windows.Forms.TabPage tabPage_Graphics;
        private System.Windows.Forms.TableLayoutPanel tlp_Graphics;
        private System.Windows.Forms.TabPage tabPage_Sound;
        private System.Windows.Forms.TabPage tabPage_Text;
        private System.Windows.Forms.TableLayoutPanel tlp_Text;
        private System.Windows.Forms.RichTextBox rtb_Log;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromFolderToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage_Overview;
        private System.Windows.Forms.TableLayoutPanel tlp_Sound;
        private System.Windows.Forms.ToolStripComboBox comboBox_Character;
        private System.Windows.Forms.ToolStripComboBox comboBox_Language;
        private System.Windows.Forms.Panel pnl_Overview;
        private System.Windows.Forms.TableLayoutPanel tlp_Overview;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.ToolStripMenuItem characterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportModToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setExtractedRomFSFolderToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox_ProfileIcon;
        private System.Windows.Forms.TableLayoutPanel tlp_ProfileIcon;
        private System.Windows.Forms.PictureBox pictureBox_ProfileIcon;
        private System.Windows.Forms.TextBox txt_ProfileIcon;
        private System.Windows.Forms.Button btn_ProfileIcon;
    }
}