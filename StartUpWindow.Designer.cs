namespace DarktideModManager
{
    partial class StartUpWindow
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
            this.ButtonExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelModsFound = new System.Windows.Forms.Label();
            this.LabelNotPatched = new System.Windows.Forms.Label();
            this.ButtonOptions = new System.Windows.Forms.Button();
            this.ButtonStartGame = new System.Windows.Forms.Button();
            this.LabelFolderError = new System.Windows.Forms.Label();
            this.LabelWindow = new System.Windows.Forms.Label();
            this.LabelVersion = new System.Windows.Forms.Label();
            this.LinkLableUpdate = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.Color.Silver;
            this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExit.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.ForeColor = System.Drawing.Color.Black;
            this.ButtonExit.Location = new System.Drawing.Point(240, -5);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(48, 23);
            this.ButtonExit.TabIndex = 2;
            this.ButtonExit.Text = "EXIT";
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.panel1.Controls.Add(this.LinkLableUpdate);
            this.panel1.Controls.Add(this.LabelVersion);
            this.panel1.Controls.Add(this.LabelModsFound);
            this.panel1.Controls.Add(this.LabelNotPatched);
            this.panel1.Controls.Add(this.ButtonOptions);
            this.panel1.Controls.Add(this.ButtonStartGame);
            this.panel1.Controls.Add(this.LabelFolderError);
            this.panel1.Location = new System.Drawing.Point(5, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 170);
            this.panel1.TabIndex = 1;
            // 
            // LabelModsFound
            // 
            this.LabelModsFound.AutoSize = true;
            this.LabelModsFound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelModsFound.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelModsFound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LabelModsFound.Location = new System.Drawing.Point(11, 12);
            this.LabelModsFound.Name = "LabelModsFound";
            this.LabelModsFound.Size = new System.Drawing.Size(126, 14);
            this.LabelModsFound.TabIndex = 2;
            this.LabelModsFound.Text = "Found 00 new mods";
            this.LabelModsFound.Visible = false;
            // 
            // LabelNotPatched
            // 
            this.LabelNotPatched.AutoSize = true;
            this.LabelNotPatched.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelNotPatched.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNotPatched.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LabelNotPatched.Location = new System.Drawing.Point(11, 26);
            this.LabelNotPatched.Name = "LabelNotPatched";
            this.LabelNotPatched.Size = new System.Drawing.Size(147, 14);
            this.LabelNotPatched.TabIndex = 2;
            this.LabelNotPatched.Text = "Game is not patched!";
            this.LabelNotPatched.Visible = false;
            // 
            // ButtonOptions
            // 
            this.ButtonOptions.BackColor = System.Drawing.Color.Silver;
            this.ButtonOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOptions.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOptions.ForeColor = System.Drawing.Color.Black;
            this.ButtonOptions.Location = new System.Drawing.Point(193, 67);
            this.ButtonOptions.Name = "ButtonOptions";
            this.ButtonOptions.Size = new System.Drawing.Size(90, 30);
            this.ButtonOptions.TabIndex = 1;
            this.ButtonOptions.Text = "Settings";
            this.ButtonOptions.UseVisualStyleBackColor = false;
            this.ButtonOptions.Click += new System.EventHandler(this.ButtonOptions_Click);
            // 
            // ButtonStartGame
            // 
            this.ButtonStartGame.BackColor = System.Drawing.Color.Silver;
            this.ButtonStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonStartGame.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonStartGame.ForeColor = System.Drawing.Color.Black;
            this.ButtonStartGame.Location = new System.Drawing.Point(193, 103);
            this.ButtonStartGame.Name = "ButtonStartGame";
            this.ButtonStartGame.Size = new System.Drawing.Size(90, 60);
            this.ButtonStartGame.TabIndex = 0;
            this.ButtonStartGame.Text = "Launch Darktide";
            this.ButtonStartGame.UseVisualStyleBackColor = false;
            this.ButtonStartGame.Click += new System.EventHandler(this.ButtonStartGame_Click);
            // 
            // LabelFolderError
            // 
            this.LabelFolderError.AutoSize = true;
            this.LabelFolderError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelFolderError.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFolderError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LabelFolderError.Location = new System.Drawing.Point(11, 40);
            this.LabelFolderError.Name = "LabelFolderError";
            this.LabelFolderError.Size = new System.Drawing.Size(182, 14);
            this.LabelFolderError.TabIndex = 2;
            this.LabelFolderError.Text = "Game folder not selected!";
            this.LabelFolderError.Visible = false;
            // 
            // LabelWindow
            // 
            this.LabelWindow.AutoSize = true;
            this.LabelWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelWindow.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWindow.Location = new System.Drawing.Point(8, 5);
            this.LabelWindow.Name = "LabelWindow";
            this.LabelWindow.Size = new System.Drawing.Size(147, 14);
            this.LabelWindow.TabIndex = 2;
            this.LabelWindow.Text = "Darktide Mod Manager";
            this.LabelWindow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartUpWindow_MouseDown);
            this.LabelWindow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StartUpWindow_MouseUp);
            // 
            // LabelVersion
            // 
            this.LabelVersion.AutoSize = true;
            this.LabelVersion.Location = new System.Drawing.Point(6, 151);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(27, 13);
            this.LabelVersion.TabIndex = 3;
            this.LabelVersion.Text = "N/A";
            // 
            // LinkLableUpdate
            // 
            this.LinkLableUpdate.ActiveLinkColor = System.Drawing.Color.Silver;
            this.LinkLableUpdate.AutoSize = true;
            this.LinkLableUpdate.BackColor = System.Drawing.Color.Transparent;
            this.LinkLableUpdate.LinkColor = System.Drawing.Color.White;
            this.LinkLableUpdate.Location = new System.Drawing.Point(40, 151);
            this.LinkLableUpdate.Name = "LinkLableUpdate";
            this.LinkLableUpdate.Size = new System.Drawing.Size(97, 13);
            this.LinkLableUpdate.TabIndex = 4;
            this.LinkLableUpdate.TabStop = true;
            this.LinkLableUpdate.Text = "Update is available";
            this.LinkLableUpdate.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // StartUpWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.LabelWindow);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartUpWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartUpWindow";
            this.Load += new System.EventHandler(this.StartUpWindow_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartUpWindow_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StartUpWindow_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelWindow;
        private System.Windows.Forms.Button ButtonStartGame;
        private System.Windows.Forms.Button ButtonOptions;
        private System.Windows.Forms.Label LabelNotPatched;
        private System.Windows.Forms.Label LabelFolderError;
        private System.Windows.Forms.Label LabelModsFound;
        private System.Windows.Forms.Label LabelVersion;
        private System.Windows.Forms.LinkLabel LinkLableUpdate;
    }
}