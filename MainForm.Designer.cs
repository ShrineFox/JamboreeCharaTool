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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer_Main = new System.Windows.Forms.SplitContainer();
            this.metroSetTabControl_Main = new MetroSet_UI.Controls.MetroSetTabControl();
            this.tabPage_Graphics = new System.Windows.Forms.TabPage();
            this.tlp_Graphics = new System.Windows.Forms.TableLayoutPanel();
            this.tabPage_Sound = new System.Windows.Forms.TabPage();
            this.tabPage_Text = new System.Windows.Forms.TabPage();
            this.tlp_Text = new System.Windows.Forms.TableLayoutPanel();
            this.rtb_Log = new System.Windows.Forms.RichTextBox();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage_Overview = new System.Windows.Forms.TabPage();
            this.tlp_Sound = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_Overview = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Main)).BeginInit();
            this.splitContainer_Main.Panel1.SuspendLayout();
            this.splitContainer_Main.Panel2.SuspendLayout();
            this.splitContainer_Main.SuspendLayout();
            this.metroSetTabControl_Main.SuspendLayout();
            this.tabPage_Graphics.SuspendLayout();
            this.tabPage_Sound.SuspendLayout();
            this.tabPage_Text.SuspendLayout();
            this.tabPage_Overview.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowDrop = true;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toggleThemeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(2, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(778, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadProjectToolStripMenuItem,
            this.saveProjectToolStripMenuItem,
            this.importToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadProjectToolStripMenuItem
            // 
            this.loadProjectToolStripMenuItem.Name = "loadProjectToolStripMenuItem";
            this.loadProjectToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.loadProjectToolStripMenuItem.Text = "Load Project";
            // 
            // saveProjectToolStripMenuItem
            // 
            this.saveProjectToolStripMenuItem.Name = "saveProjectToolStripMenuItem";
            this.saveProjectToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveProjectToolStripMenuItem.Text = "Save Project";
            // 
            // toggleThemeToolStripMenuItem
            // 
            this.toggleThemeToolStripMenuItem.Name = "toggleThemeToolStripMenuItem";
            this.toggleThemeToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.toggleThemeToolStripMenuItem.Text = "Toggle Theme";
            // 
            // splitContainer_Main
            // 
            this.splitContainer_Main.AllowDrop = true;
            this.splitContainer_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Main.Location = new System.Drawing.Point(2, 28);
            this.splitContainer_Main.Name = "splitContainer_Main";
            this.splitContainer_Main.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_Main.Panel1
            // 
            this.splitContainer_Main.Panel1.AllowDrop = true;
            this.splitContainer_Main.Panel1.Controls.Add(this.metroSetTabControl_Main);
            // 
            // splitContainer_Main.Panel2
            // 
            this.splitContainer_Main.Panel2.AllowDrop = true;
            this.splitContainer_Main.Panel2.Controls.Add(this.rtb_Log);
            this.splitContainer_Main.Size = new System.Drawing.Size(778, 573);
            this.splitContainer_Main.SplitterDistance = 508;
            this.splitContainer_Main.TabIndex = 2;
            // 
            // metroSetTabControl_Main
            // 
            this.metroSetTabControl_Main.AllowDrop = true;
            this.metroSetTabControl_Main.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.metroSetTabControl_Main.AnimateTime = 200;
            this.metroSetTabControl_Main.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetTabControl_Main.Controls.Add(this.tabPage_Overview);
            this.metroSetTabControl_Main.Controls.Add(this.tabPage_Graphics);
            this.metroSetTabControl_Main.Controls.Add(this.tabPage_Sound);
            this.metroSetTabControl_Main.Controls.Add(this.tabPage_Text);
            this.metroSetTabControl_Main.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroSetTabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetTabControl_Main.IsDerivedStyle = true;
            this.metroSetTabControl_Main.ItemSize = new System.Drawing.Size(100, 38);
            this.metroSetTabControl_Main.Location = new System.Drawing.Point(0, 0);
            this.metroSetTabControl_Main.Name = "metroSetTabControl_Main";
            this.metroSetTabControl_Main.SelectedIndex = 0;
            this.metroSetTabControl_Main.SelectedTextColor = System.Drawing.Color.White;
            this.metroSetTabControl_Main.Size = new System.Drawing.Size(778, 508);
            this.metroSetTabControl_Main.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroSetTabControl_Main.Speed = 100;
            this.metroSetTabControl_Main.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetTabControl_Main.StyleManager = null;
            this.metroSetTabControl_Main.TabIndex = 2;
            this.metroSetTabControl_Main.TabStyle = MetroSet_UI.Enums.TabStyle.Style2;
            this.metroSetTabControl_Main.ThemeAuthor = "Narwin";
            this.metroSetTabControl_Main.ThemeName = "MetroDark";
            this.metroSetTabControl_Main.UnselectedTextColor = System.Drawing.Color.Gray;
            this.metroSetTabControl_Main.UseAnimation = false;
            // 
            // tabPage_Graphics
            // 
            this.tabPage_Graphics.AllowDrop = true;
            this.tabPage_Graphics.Controls.Add(this.tlp_Graphics);
            this.tabPage_Graphics.Location = new System.Drawing.Point(4, 42);
            this.tabPage_Graphics.Name = "tabPage_Graphics";
            this.tabPage_Graphics.Size = new System.Drawing.Size(770, 462);
            this.tabPage_Graphics.TabIndex = 0;
            this.tabPage_Graphics.Text = "Graphics";
            // 
            // tlp_Graphics
            // 
            this.tlp_Graphics.AllowDrop = true;
            this.tlp_Graphics.ColumnCount = 2;
            this.tlp_Graphics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Graphics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Graphics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Graphics.Location = new System.Drawing.Point(0, 0);
            this.tlp_Graphics.Name = "tlp_Graphics";
            this.tlp_Graphics.RowCount = 2;
            this.tlp_Graphics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlp_Graphics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tlp_Graphics.Size = new System.Drawing.Size(770, 462);
            this.tlp_Graphics.TabIndex = 3;
            // 
            // tabPage_Sound
            // 
            this.tabPage_Sound.AllowDrop = true;
            this.tabPage_Sound.Controls.Add(this.tlp_Sound);
            this.tabPage_Sound.Location = new System.Drawing.Point(4, 42);
            this.tabPage_Sound.Name = "tabPage_Sound";
            this.tabPage_Sound.Size = new System.Drawing.Size(770, 462);
            this.tabPage_Sound.TabIndex = 1;
            this.tabPage_Sound.Text = "Sound";
            // 
            // tabPage_Text
            // 
            this.tabPage_Text.Controls.Add(this.tlp_Text);
            this.tabPage_Text.Location = new System.Drawing.Point(4, 42);
            this.tabPage_Text.Name = "tabPage_Text";
            this.tabPage_Text.Size = new System.Drawing.Size(770, 462);
            this.tabPage_Text.TabIndex = 2;
            this.tabPage_Text.Text = "Text";
            // 
            // tlp_Text
            // 
            this.tlp_Text.ColumnCount = 2;
            this.tlp_Text.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Text.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Text.Location = new System.Drawing.Point(0, 0);
            this.tlp_Text.Name = "tlp_Text";
            this.tlp_Text.RowCount = 1;
            this.tlp_Text.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Text.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Text.Size = new System.Drawing.Size(770, 462);
            this.tlp_Text.TabIndex = 3;
            // 
            // rtb_Log
            // 
            this.rtb_Log.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rtb_Log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rtb_Log.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.rtb_Log.Location = new System.Drawing.Point(0, 0);
            this.rtb_Log.Name = "rtb_Log";
            this.rtb_Log.ReadOnly = true;
            this.rtb_Log.Size = new System.Drawing.Size(778, 61);
            this.rtb_Log.TabIndex = 0;
            this.rtb_Log.Text = "";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromFileToolStripMenuItem,
            this.fromFolderToolStripMenuItem});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.importToolStripMenuItem.Text = "Import...";
            // 
            // fromFileToolStripMenuItem
            // 
            this.fromFileToolStripMenuItem.Name = "fromFileToolStripMenuItem";
            this.fromFileToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.fromFileToolStripMenuItem.Text = "From File";
            // 
            // fromFolderToolStripMenuItem
            // 
            this.fromFolderToolStripMenuItem.Name = "fromFolderToolStripMenuItem";
            this.fromFolderToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.fromFolderToolStripMenuItem.Text = "From Folder";
            this.fromFolderToolStripMenuItem.Click += new System.EventHandler(this.ImportFromFolder_Click);
            // 
            // tabPage_Overview
            // 
            this.tabPage_Overview.Controls.Add(this.tlp_Overview);
            this.tabPage_Overview.Location = new System.Drawing.Point(4, 42);
            this.tabPage_Overview.Name = "tabPage_Overview";
            this.tabPage_Overview.Size = new System.Drawing.Size(770, 462);
            this.tabPage_Overview.TabIndex = 3;
            this.tabPage_Overview.Text = "Overview";
            // 
            // tlp_Sound
            // 
            this.tlp_Sound.AllowDrop = true;
            this.tlp_Sound.ColumnCount = 2;
            this.tlp_Sound.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Sound.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Sound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Sound.Location = new System.Drawing.Point(0, 0);
            this.tlp_Sound.Name = "tlp_Sound";
            this.tlp_Sound.RowCount = 2;
            this.tlp_Sound.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlp_Sound.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tlp_Sound.Size = new System.Drawing.Size(770, 462);
            this.tlp_Sound.TabIndex = 4;
            // 
            // tlp_Overview
            // 
            this.tlp_Overview.AllowDrop = true;
            this.tlp_Overview.ColumnCount = 2;
            this.tlp_Overview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Overview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Overview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Overview.Location = new System.Drawing.Point(0, 0);
            this.tlp_Overview.Name = "tlp_Overview";
            this.tlp_Overview.RowCount = 2;
            this.tlp_Overview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlp_Overview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tlp_Overview.Size = new System.Drawing.Size(770, 462);
            this.tlp_Overview.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(782, 603);
            this.Controls.Add(this.splitContainer_Main);
            this.Controls.Add(this.menuStrip1);
            this.DropShadowEffect = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.HeaderHeight = -40;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 650);
            this.Name = "MainForm";
            this.Opacity = 0.99D;
            this.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.ShowHeader = true;
            this.ShowLeftRect = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Style = MetroSet_UI.Enums.Style.Dark;
            this.Text = "PersonaVCE v2.3.2";
            this.TextColor = System.Drawing.Color.White;
            this.ThemeName = "MetroDark";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer_Main.Panel1.ResumeLayout(false);
            this.splitContainer_Main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Main)).EndInit();
            this.splitContainer_Main.ResumeLayout(false);
            this.metroSetTabControl_Main.ResumeLayout(false);
            this.tabPage_Graphics.ResumeLayout(false);
            this.tabPage_Sound.ResumeLayout(false);
            this.tabPage_Text.ResumeLayout(false);
            this.tabPage_Overview.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleThemeToolStripMenuItem;
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
        private System.Windows.Forms.TableLayoutPanel tlp_Overview;
    }
}