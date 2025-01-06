using DarktideModManager.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarktideModManager
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        [Conditional("DEBUG")]
        private void DebugCheck()
        {
            isInDebug = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DebugCheck();
            _gamePath = Settings.Default.GamePath;
            SelectedFolderBox.Text = Settings.Default.GamePath;
            folderBrowserDialog1.SelectedPath = Settings.Default.GamePath;

            if (_gamePath.Contains("Warhammer 40,000 DARKTIDE"))
            {
                CreateModList();
            }

            if (isInDebug)
            {
                button1.Show();
            }
        }

        private void PatchButton_Click(object sender, EventArgs e)
        {
            if (_gamePath.Contains("Warhammer 40,000 DARKTIDE"))
            {
                if (!IsPatched())
                {
                    Process.Start($"{_gamePath}\\tools\\dtkit-patch");
                }
                else
                {
                    MessageBox.Show("Game is already patched!", "Attention!");
                }
            }
            else
            {
                MessageBox.Show("Game folder not selected!", "Error!");
            }
        }

        private void AuthorLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://next.nexusmods.com/profile/SharkySan/about-me");
        }

        private void ModPageLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.nexusmods.com/warhammer40kdarktide/mods/76");
        }

        private void FolderButton_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                _gamePath = folderBrowserDialog1.SelectedPath;
                SelectedFolderBox.Text = folderBrowserDialog1.SelectedPath;
                Settings.Default.GamePath = folderBrowserDialog1.SelectedPath;
                Settings.Default.Save();

                if (_gamePath.Contains("Warhammer 40,000 DARKTIDE"))
                {
                    CreateModList();
                }
            }
            else if (result == DialogResult.Cancel)
            {
                // Do nothing
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ModNameButton_Click(object sender, EventArgs e)
        {
            AuthorLink.Focus();
            var tabIndex = (sender as Button).Parent.TabIndex;
            if (modList[tabIndex].IsActive)
            {
                modList[tabIndex].IsActive = false;
                (sender as Button).BackColor = Color.Silver;
            }
            else
            {
                modList[tabIndex].IsActive = true;
                (sender as Button).BackColor = Color.MediumTurquoise;
            }
        }

        #region Movable Window

        Timer moveFormTimer;
        int posX;
        int posY;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            moveFormTimer = new Timer
            {
                Interval = 12
            };
            moveFormTimer.Start();
            moveFormTimer.Tick += MoveFormTimer_Tick;

            posX = e.X;
            posY = e.Y;
        }

        private void MoveFormTimer_Tick(object sender, EventArgs e)
        {
            Left = MousePosition.X - posX;
            Top = MousePosition.Y - posY;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            moveFormTimer?.Stop();
        }

        #endregion

        private void ButtonMainTab_Click(object sender, EventArgs e)
        {
            PanelMain.Visible = true;
            PanelSettings.Visible = false;
            PanelAbout.Visible = false;

            ButtonMainTab.BackColor = Color.FromArgb(90, 90, 90);
            ButtonSettingsTab.BackColor = Color.Gray;
            ButtonAboutTab.BackColor = Color.Gray;

            LabelWindow.Select();
        }

        private void ButtonSettingsTab_Click(object sender, EventArgs e)
        {
            PanelMain.Visible = false;
            PanelSettings.Visible = true;
            PanelAbout.Visible = false;

            ButtonMainTab.BackColor = Color.Gray;
            ButtonSettingsTab.BackColor = Color.FromArgb(90, 90, 90);
            ButtonAboutTab.BackColor = Color.Gray;

            LabelWindow.Select();
        }

        private void ButtonAboutTab_Click(object sender, EventArgs e)
        {
            PanelMain.Visible = false;
            PanelSettings.Visible = false;
            PanelAbout.Visible = true;

            ButtonMainTab.BackColor = Color.Gray;
            ButtonSettingsTab.BackColor = Color.Gray;
            ButtonAboutTab.BackColor = Color.FromArgb(90, 90, 90);

            LabelWindow.Select();
        }

        private void ButtonReturn_Click(object sender, EventArgs e)
        {
            var StartupWindow = new StartUpWindow();

            StartupWindow.Show();
            this.Hide();
        }

        private void ButtonOpenFolder_Click(object sender, EventArgs e)
        {
            if (SelectedFolderBox.Text != "")
            {
                Process.Start(SelectedFolderBox.Text);
            }
        }

        private void ButtonSaveMods_Click(object sender, EventArgs e)
        {
            if (_gamePath.Contains("Warhammer 40,000 DARKTIDE"))
            {
                SaveModList();
                MessageBox.Show("Mod list created!", "Success!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.Default.Reset();
        }

        private void ButtonSort_Click(object sender, EventArgs e)
        {
            List<string> activeMods = new List<string>();
            List<string> disabledMods = new List<string>();

            for (int i = 0; i < ModListBox.Controls.Count; i++)
            {
                if (ModListBox.Controls[i].Controls[1].BackColor == Color.MediumTurquoise)
                {
                    activeMods.Add(ModListBox.Controls[i].Controls[1].Text);
                }
                else
                {
                    disabledMods.Add(ModListBox.Controls[i].Controls[1].Text);
                }
            }

            ModListBox.Controls.Clear();
            activeMods.Sort();

            for (int i = 0; i < activeMods.Count; i++)
            {
                ModListBox.Controls.Add(CreateButton(i + 1, activeMods[i], true));
            }

            for (int i = 0; i < disabledMods.Count; i++)
            {
                ModListBox.Controls.Add(CreateButton(ModListBox.Controls.Count + 1, disabledMods[i], false));
            }
        }

        private void LinkLabelGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"https://github.com/Futashy/DarktideModManager");
        }
    }
}
