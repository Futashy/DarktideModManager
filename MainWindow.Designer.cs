namespace DarktideModManager
{
    partial class MainWindow
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
            this.ModListBox = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonSaveMods = new System.Windows.Forms.Button();
            this.SelectedFolderBox = new System.Windows.Forms.TextBox();
            this.AuthorLink = new System.Windows.Forms.LinkLabel();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.PatchButton = new System.Windows.Forms.Button();
            this.ModPageLink = new System.Windows.Forms.LinkLabel();
            this.FolderButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ButtonMainTab = new System.Windows.Forms.Button();
            this.ButtonSettingsTab = new System.Windows.Forms.Button();
            this.ButtonAboutTab = new System.Windows.Forms.Button();
            this.ButtonReturn = new System.Windows.Forms.Button();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.TextBoxDescrition = new System.Windows.Forms.TextBox();
            this.ButtonSort = new System.Windows.Forms.Button();
            this.PanelSettings = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonOpenFolder = new System.Windows.Forms.Button();
            this.PanelAbout = new System.Windows.Forms.Panel();
            this.TextBoxAbout = new System.Windows.Forms.TextBox();
            this.LinkLabelGithub = new System.Windows.Forms.LinkLabel();
            this.LabelWindow = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.PanelMain.SuspendLayout();
            this.PanelSettings.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.PanelAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // ModListBox
            // 
            this.ModListBox.AllowDrop = true;
            this.ModListBox.AutoScroll = true;
            this.ModListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.ModListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModListBox.Location = new System.Drawing.Point(7, 8);
            this.ModListBox.Margin = new System.Windows.Forms.Padding(0);
            this.ModListBox.Name = "ModListBox";
            this.ModListBox.Size = new System.Drawing.Size(299, 452);
            this.ModListBox.TabIndex = 0;
            // 
            // ButtonSaveMods
            // 
            this.ButtonSaveMods.BackColor = System.Drawing.Color.DarkGray;
            this.ButtonSaveMods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSaveMods.Location = new System.Drawing.Point(332, 400);
            this.ButtonSaveMods.Name = "ButtonSaveMods";
            this.ButtonSaveMods.Size = new System.Drawing.Size(142, 42);
            this.ButtonSaveMods.TabIndex = 0;
            this.ButtonSaveMods.Text = "SAVE";
            this.ButtonSaveMods.UseVisualStyleBackColor = false;
            this.ButtonSaveMods.Click += new System.EventHandler(this.ButtonSaveMods_Click);
            // 
            // SelectedFolderBox
            // 
            this.SelectedFolderBox.BackColor = System.Drawing.Color.Silver;
            this.SelectedFolderBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectedFolderBox.Location = new System.Drawing.Point(6, 19);
            this.SelectedFolderBox.Name = "SelectedFolderBox";
            this.SelectedFolderBox.ReadOnly = true;
            this.SelectedFolderBox.Size = new System.Drawing.Size(476, 20);
            this.SelectedFolderBox.TabIndex = 2;
            this.SelectedFolderBox.TabStop = false;
            // 
            // AuthorLink
            // 
            this.AuthorLink.AutoSize = true;
            this.AuthorLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.AuthorLink.LinkColor = System.Drawing.Color.Gold;
            this.AuthorLink.Location = new System.Drawing.Point(440, 392);
            this.AuthorLink.Name = "AuthorLink";
            this.AuthorLink.Size = new System.Drawing.Size(38, 13);
            this.AuthorLink.TabIndex = 5;
            this.AuthorLink.TabStop = true;
            this.AuthorLink.Text = "Author";
            this.AuthorLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AuthorLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AuthorLink_LinkClicked);
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.Color.Silver;
            this.ButtonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExit.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonExit.Location = new System.Drawing.Point(538, -3);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(48, 23);
            this.ButtonExit.TabIndex = 2;
            this.ButtonExit.Text = "EXIT";
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // PatchButton
            // 
            this.PatchButton.BackColor = System.Drawing.Color.Gray;
            this.PatchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PatchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatchButton.Location = new System.Drawing.Point(350, 418);
            this.PatchButton.Name = "PatchButton";
            this.PatchButton.Size = new System.Drawing.Size(142, 42);
            this.PatchButton.TabIndex = 1;
            this.PatchButton.Text = "PATCH THE GAME";
            this.PatchButton.UseVisualStyleBackColor = false;
            this.PatchButton.Click += new System.EventHandler(this.PatchButton_Click);
            // 
            // ModPageLink
            // 
            this.ModPageLink.AutoSize = true;
            this.ModPageLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ModPageLink.LinkColor = System.Drawing.Color.Gold;
            this.ModPageLink.Location = new System.Drawing.Point(422, 435);
            this.ModPageLink.Name = "ModPageLink";
            this.ModPageLink.Size = new System.Drawing.Size(56, 13);
            this.ModPageLink.TabIndex = 5;
            this.ModPageLink.TabStop = true;
            this.ModPageLink.Text = "Mod Page";
            this.ModPageLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ModPageLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ModPageLink_LinkClicked);
            // 
            // FolderButton
            // 
            this.FolderButton.BackColor = System.Drawing.Color.Gray;
            this.FolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FolderButton.ForeColor = System.Drawing.Color.Black;
            this.FolderButton.Location = new System.Drawing.Point(6, 45);
            this.FolderButton.Name = "FolderButton";
            this.FolderButton.Size = new System.Drawing.Size(80, 25);
            this.FolderButton.TabIndex = 6;
            this.FolderButton.Text = "Select Folder";
            this.FolderButton.UseVisualStyleBackColor = false;
            this.FolderButton.Click += new System.EventHandler(this.FolderButton_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ButtonMainTab);
            this.panel1.Controls.Add(this.ButtonSettingsTab);
            this.panel1.Controls.Add(this.ButtonAboutTab);
            this.panel1.Controls.Add(this.ButtonReturn);
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 469);
            this.panel1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonMainTab
            // 
            this.ButtonMainTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.ButtonMainTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonMainTab.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonMainTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMainTab.Location = new System.Drawing.Point(1, 1);
            this.ButtonMainTab.Name = "ButtonMainTab";
            this.ButtonMainTab.Size = new System.Drawing.Size(100, 98);
            this.ButtonMainTab.TabIndex = 0;
            this.ButtonMainTab.Text = "MOD LIST";
            this.ButtonMainTab.UseVisualStyleBackColor = false;
            this.ButtonMainTab.Click += new System.EventHandler(this.ButtonMainTab_Click);
            // 
            // ButtonSettingsTab
            // 
            this.ButtonSettingsTab.BackColor = System.Drawing.Color.Gray;
            this.ButtonSettingsTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSettingsTab.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonSettingsTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSettingsTab.Location = new System.Drawing.Point(1, 98);
            this.ButtonSettingsTab.Name = "ButtonSettingsTab";
            this.ButtonSettingsTab.Size = new System.Drawing.Size(100, 98);
            this.ButtonSettingsTab.TabIndex = 0;
            this.ButtonSettingsTab.Text = "OPTIONS";
            this.ButtonSettingsTab.UseVisualStyleBackColor = false;
            this.ButtonSettingsTab.Click += new System.EventHandler(this.ButtonSettingsTab_Click);
            // 
            // ButtonAboutTab
            // 
            this.ButtonAboutTab.BackColor = System.Drawing.Color.Gray;
            this.ButtonAboutTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAboutTab.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonAboutTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAboutTab.Location = new System.Drawing.Point(1, 195);
            this.ButtonAboutTab.Name = "ButtonAboutTab";
            this.ButtonAboutTab.Size = new System.Drawing.Size(100, 98);
            this.ButtonAboutTab.TabIndex = 0;
            this.ButtonAboutTab.Text = "ABOUT";
            this.ButtonAboutTab.UseVisualStyleBackColor = false;
            this.ButtonAboutTab.Click += new System.EventHandler(this.ButtonAboutTab_Click);
            // 
            // ButtonReturn
            // 
            this.ButtonReturn.BackColor = System.Drawing.Color.Silver;
            this.ButtonReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonReturn.Location = new System.Drawing.Point(11, 426);
            this.ButtonReturn.Name = "ButtonReturn";
            this.ButtonReturn.Size = new System.Drawing.Size(76, 30);
            this.ButtonReturn.TabIndex = 0;
            this.ButtonReturn.Text = "RETURN";
            this.ButtonReturn.UseVisualStyleBackColor = false;
            this.ButtonReturn.Click += new System.EventHandler(this.ButtonReturn_Click);
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.PanelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelMain.Controls.Add(this.TextBoxDescrition);
            this.PanelMain.Controls.Add(this.ModListBox);
            this.PanelMain.Controls.Add(this.ButtonSort);
            this.PanelMain.Controls.Add(this.ButtonSaveMods);
            this.PanelMain.Location = new System.Drawing.Point(100, 31);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(497, 469);
            this.PanelMain.TabIndex = 8;
            // 
            // TextBoxDescrition
            // 
            this.TextBoxDescrition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.TextBoxDescrition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxDescrition.Cursor = System.Windows.Forms.Cursors.Default;
            this.TextBoxDescrition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDescrition.ForeColor = System.Drawing.Color.Black;
            this.TextBoxDescrition.Location = new System.Drawing.Point(309, 8);
            this.TextBoxDescrition.Multiline = true;
            this.TextBoxDescrition.Name = "TextBoxDescrition";
            this.TextBoxDescrition.ReadOnly = true;
            this.TextBoxDescrition.Size = new System.Drawing.Size(183, 57);
            this.TextBoxDescrition.TabIndex = 3;
            this.TextBoxDescrition.TabStop = false;
            this.TextBoxDescrition.Text = "\"dmf\" and \"base\" mods are ignored and won\'t appear in the list";
            this.TextBoxDescrition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ButtonSort
            // 
            this.ButtonSort.BackColor = System.Drawing.Color.DarkGray;
            this.ButtonSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSort.Location = new System.Drawing.Point(332, 352);
            this.ButtonSort.Name = "ButtonSort";
            this.ButtonSort.Size = new System.Drawing.Size(142, 42);
            this.ButtonSort.TabIndex = 0;
            this.ButtonSort.Text = "AUTO SORT";
            this.ButtonSort.UseVisualStyleBackColor = false;
            this.ButtonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // PanelSettings
            // 
            this.PanelSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.PanelSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelSettings.Controls.Add(this.groupBox2);
            this.PanelSettings.Controls.Add(this.groupBox1);
            this.PanelSettings.Controls.Add(this.PatchButton);
            this.PanelSettings.Location = new System.Drawing.Point(100, 31);
            this.PanelSettings.Name = "PanelSettings";
            this.PanelSettings.Size = new System.Drawing.Size(497, 469);
            this.PanelSettings.TabIndex = 8;
            this.PanelSettings.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(3, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 324);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Launch Options";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(141, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Skip launcher on startup";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SelectedFolderBox);
            this.groupBox1.Controls.Add(this.ButtonOpenFolder);
            this.groupBox1.Controls.Add(this.FolderButton);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 79);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Folder";
            // 
            // ButtonOpenFolder
            // 
            this.ButtonOpenFolder.BackColor = System.Drawing.Color.Gray;
            this.ButtonOpenFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonOpenFolder.ForeColor = System.Drawing.Color.Black;
            this.ButtonOpenFolder.Location = new System.Drawing.Point(92, 45);
            this.ButtonOpenFolder.Name = "ButtonOpenFolder";
            this.ButtonOpenFolder.Size = new System.Drawing.Size(80, 25);
            this.ButtonOpenFolder.TabIndex = 6;
            this.ButtonOpenFolder.Text = "Open Folder";
            this.ButtonOpenFolder.UseVisualStyleBackColor = false;
            this.ButtonOpenFolder.Click += new System.EventHandler(this.ButtonOpenFolder_Click);
            // 
            // PanelAbout
            // 
            this.PanelAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.PanelAbout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelAbout.Controls.Add(this.TextBoxAbout);
            this.PanelAbout.Controls.Add(this.LinkLabelGithub);
            this.PanelAbout.Controls.Add(this.AuthorLink);
            this.PanelAbout.Controls.Add(this.ModPageLink);
            this.PanelAbout.Location = new System.Drawing.Point(100, 31);
            this.PanelAbout.Name = "PanelAbout";
            this.PanelAbout.Size = new System.Drawing.Size(497, 469);
            this.PanelAbout.TabIndex = 8;
            this.PanelAbout.Visible = false;
            // 
            // TextBoxAbout
            // 
            this.TextBoxAbout.BackColor = System.Drawing.Color.Gray;
            this.TextBoxAbout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxAbout.Location = new System.Drawing.Point(17, 22);
            this.TextBoxAbout.Multiline = true;
            this.TextBoxAbout.Name = "TextBoxAbout";
            this.TextBoxAbout.Size = new System.Drawing.Size(461, 338);
            this.TextBoxAbout.TabIndex = 6;
            this.TextBoxAbout.Text = "WIP";
            this.TextBoxAbout.Visible = false;
            // 
            // LinkLabelGithub
            // 
            this.LinkLabelGithub.AutoSize = true;
            this.LinkLabelGithub.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LinkLabelGithub.LinkColor = System.Drawing.Color.Gold;
            this.LinkLabelGithub.Location = new System.Drawing.Point(435, 415);
            this.LinkLabelGithub.Name = "LinkLabelGithub";
            this.LinkLabelGithub.Size = new System.Drawing.Size(43, 13);
            this.LinkLabelGithub.TabIndex = 5;
            this.LinkLabelGithub.TabStop = true;
            this.LinkLabelGithub.Text = "Git-Hub";
            this.LinkLabelGithub.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LinkLabelGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelGithub_LinkClicked);
            // 
            // LabelWindow
            // 
            this.LabelWindow.AutoSize = true;
            this.LabelWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelWindow.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWindow.ForeColor = System.Drawing.Color.White;
            this.LabelWindow.Location = new System.Drawing.Point(12, 9);
            this.LabelWindow.Name = "LabelWindow";
            this.LabelWindow.Size = new System.Drawing.Size(147, 14);
            this.LabelWindow.TabIndex = 9;
            this.LabelWindow.Text = "Darktide Mod Manager";
            this.LabelWindow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.LabelWindow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(597, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LabelWindow);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.PanelAbout);
            this.Controls.Add(this.PanelSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            this.PanelSettings.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PanelAbout.ResumeLayout(false);
            this.PanelAbout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonSaveMods;
        private System.Windows.Forms.TextBox SelectedFolderBox;
        public System.Windows.Forms.FlowLayoutPanel ModListBox;
        private System.Windows.Forms.LinkLabel AuthorLink;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button PatchButton;
        private System.Windows.Forms.LinkLabel ModPageLink;
        private System.Windows.Forms.Button FolderButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonMainTab;
        private System.Windows.Forms.Button ButtonSettingsTab;
        private System.Windows.Forms.Button ButtonAboutTab;
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Panel PanelSettings;
        private System.Windows.Forms.Panel PanelAbout;
        private System.Windows.Forms.Button ButtonReturn;
        private System.Windows.Forms.TextBox TextBoxDescrition;
        private System.Windows.Forms.TextBox TextBoxAbout;
        private System.Windows.Forms.Button ButtonOpenFolder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LabelWindow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button ButtonSort;
        private System.Windows.Forms.LinkLabel LinkLabelGithub;
    }
}

