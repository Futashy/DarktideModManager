using DarktideModManager.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarktideModManager
{
    public partial class StartUpWindow : Form
    {
        public StartUpWindow()
        {
            InitializeComponent();
        }

        private string gamePath = "";

        private List<string> activeMods;
        private List<string> disabledMods;
        private string[] ignoredList = { "base", "dmf" };


        private void StartUpWindow_Load(object sender, EventArgs e)
        {
            UpdateManager();

            gamePath = Settings.Default.GamePath;

            if (gamePath == "" | !gamePath.Contains("Warhammer 40,000 DARKTIDE"))
            {
                LabelFolderError.Visible = true;
            }
            else
            {
                if (!File.ReadAllText($"{gamePath}\\bundle\\bundle_database.data").Contains("patch_999"))
                {
                    LabelNotPatched.Visible = true;
                }

                GetActiveMods(gamePath + "\\mods");
                GetDisabledMods(gamePath + "\\mods");

                int count = CountNewMods();

                if (count == 1)
                {
                    LabelModsFound.Visible = true;
                    LabelModsFound.Text = $"Found {count} disabled mod";
                }
                else if (count > 1)
                {
                    LabelModsFound.Visible = true;
                    LabelModsFound.Text = $"Found {count} disabled mods";
                }
            }
        }

        private void UpdateManager()
        {
            LabelVersion.Text = Settings.Default.Version;

            string xml = new WebClient().DownloadString(@"https://raw.githubusercontent.com/Futashy/DarktideModManager/refs/heads/master/README.md");
        }

        private void ButtonOptions_Click(object sender, EventArgs e)
        {
            var mainWindow = new MainWindow();

            mainWindow.Show();
            this.Hide();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private List<string> GetActiveMods(string path)
        {
            activeMods = new List<string>();
            string modFilePath = $"{path}\\mod_load_order.txt";

            using (StreamReader file = new StreamReader(modFilePath))
            {
                string line;

                while ((line = file.ReadLine()) != null)
                {
                    activeMods.Add(line);
                }

                file.Close();
            }

            return activeMods;
        }

        private List<string> GetDisabledMods(string path)
        {
            DirectoryInfo[] dirs = new DirectoryInfo(path).GetDirectories();

            disabledMods = new List<string>();

            for (int i = 0; i < dirs.Length; i++)
            {
                for (int j = 0; j < activeMods.Count; j++)
                {
                    if (activeMods[j] == dirs[i].Name)
                    {
                        break;
                    }
                    else if (j == activeMods.Count - 1)
                    {
                        disabledMods.Add(dirs[i].Name);
                    }
                }
            }

            return disabledMods;
        }

        private int CountNewMods()
        {
            int result = 0;

            for (int i = 0; i < disabledMods.Count; i++)
            {
                for (int j = 0; j < ignoredList.Length; j++)
                {
                    if (disabledMods[i].Contains(ignoredList[j]))
                    {
                        break;
                    }
                    else if (j == ignoredList.Length - 1)
                    {
                        result++;
                    }
                }
            }

            return result;
        }

        #region Movable Window

        Timer moveFormTimer;
        int posX;
        int posY;

        private void StartUpWindow_MouseDown(object sender, MouseEventArgs e)
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

        private void StartUpWindow_MouseUp(object sender, MouseEventArgs e)
        {
            moveFormTimer?.Stop();
        }

        #endregion

        private void ButtonStartGame_Click(object sender, EventArgs e)
        {
            if (IsPatched())
            {
                //Process.Start("steam://rungameid/1361210"); // in case if needed to launch through steam
                Process.Start($"{gamePath}\\launcher\\Launcher.exe");
                Application.Exit();
            }
            else
            {
                DialogResult result = MessageBox.Show("The game is not patched\nLaunch the game anyway?", "Warning!", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Process.Start($"{gamePath}\\launcher\\Launcher.exe");
                    Application.Exit();
                }
            }
        }

        public bool IsPatched()
        {
            bool result = File.ReadAllText($"{gamePath}\\bundle\\bundle_database.data").Contains("patch_999");

            return result;
        }
    }
}
