using System;
using System.Collections.Generic;
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
        private void CreateModList()
        {
            modList = new List<ModItem>();

            GetActiveMods();
            GetDisabledMods();
            PopulateModList();
        }

        private void GetActiveMods()
        {
            using (StreamReader file = new StreamReader($"{_gamePath}\\mods\\mod_load_order.txt"))
            {
                string line;
                int i = 0;

                while ((line = file.ReadLine()) != null)
                {
                    modList.Add(new ModItem(modList.Count + 1, line, true));
                    i++;
                }

                file.Close();
            }
        }

        private void GetDisabledMods()
        {
            DirectoryInfo[] dirs = new DirectoryInfo($"{_gamePath}\\mods").GetDirectories();

            List<string> files = new List<string>();

            for (int x = 0; x < dirs.Length; x++)
            {
                for (int y = 0; y < modList.Count; y++)
                {
                    if (modList[y].Name == dirs[x].Name)
                    {
                        break;
                    }
                    else if (y == modList.Count - 1)
                    {
                        files.Add(dirs[x].Name);
                    }
                }
            }

            foreach (var mod in _ignoredList)
            {
                files.Remove(mod);
            }

            for (int i = 0; i < files.Count; i++)
            {
                modList.Add(new ModItem(modList.Count + 1, files[i], false));
            }
        }

        private void PopulateModList()
        {
            for (int i = 0; i < modList.Count; i++)
            {
                ModListBox.Controls.Add(CreateButton(modList[i].Number, modList[i].Name, modList[i].IsActive));
            }
        }

        public bool IsPatched()
        {
            bool result = File.ReadAllText($"{_gamePath}\\bundle\\bundle_database.data").Contains("patch_999");

            return result;
        }

        public Control CreateButton(int num, string name, bool isActive)
        {
            Panel ModPanel = new Panel()
            {
                Width = 280,
                Height = 25,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(0, 0, 0, 0)
            };

            Label ModNumber = new Label()
            {
                Text = num.ToString(),
                Width = 25,
                Height = 25,
                Location = new Point(-1, -1),
                ForeColor = Color.Black,
                TextAlign = ContentAlignment.MiddleCenter,
                BorderStyle = BorderStyle.FixedSingle
            };
            ModPanel.Controls.Add(ModNumber);

            Button ModNameButton = new Button()
            {
                Text = name,
                Width = 261,
                Height = 25,
                Location = new Point(18, -1),
                BackColor = GetColor(isActive),
                FlatStyle = FlatStyle.Flat,
                AutoSize = true,
                TabStop = false
            };
            //ModNameButton.Click += ModNameButton_Click;
            ModNameButton.AllowDrop = true;
            ModNameButton.MouseDown += ModNameButton_MouseDown;
            ModNameButton.MouseUp += ModNameButton_MouseUp;
            ModNameButton.DragEnter += ModNameButton_DragEnter;
            ModNameButton.DragDrop += ModNameButton_DragDrop;
            ModNameButton.MouseMove += ModNameButton_MouseMove;

            ModPanel.Controls.Add(ModNameButton);

            return ModPanel;
        }

        private void ToggleMod(object sender)
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

        bool isMouseDown = false;

        private void ModNameButton_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            ToggleMod(sender);
        }

        private void ModNameButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown == true)
            {
                (sender as Button).DoDragDrop(sender as Button, DragDropEffects.Copy | DragDropEffects.Move);
            }
        }

        private void ModNameButton_DragDrop(object sender, DragEventArgs e)
        {
            Button obj = e.Data.GetData(e.Data.GetFormats()[0]) as Button;
            string button = obj.Text;

            if (obj.Text == (sender as Button).Text)
            {
                ToggleMod(sender);
            }
            else
            {
                var firstColor = obj.BackColor;
                var secondColor = (sender as Button).BackColor;


                for (int i = 0; i < ModListBox.Controls.Count; i++)
                {
                    if (ModListBox.Controls[i].Controls[1].Text == button)
                    {
                        ModListBox.Controls[i].Controls[1].Text = (sender as Button).Text;
                        ModListBox.Controls[i].Controls[1].BackColor = secondColor;
                        (sender as Button).Text = button;
                        (sender as Button).BackColor = firstColor;
                        break;
                    }
                }
            }

            isMouseDown = false;
        }

        private void ModNameButton_DragEnter(object sender, DragEventArgs e)
        {
            var obj = e.Data.GetData(e.Data.GetFormats()[0]);

            if (obj is Button)
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void ModNameButton_MouseDown(object sender, MouseEventArgs e)
        {
            //(sender as Button).DoDragDrop((sender as Button).Text, DragDropEffects.Copy | DragDropEffects.Move);

            isMouseDown = true;
        }

        private static Color GetColor(bool isActive)
        {
            if (isActive)
            {
                return Color.MediumTurquoise;
            }
            else
            {
                return Color.Silver;
            }
        }

        private void SaveModList()
        {
            List<string> modList = new List<string>();
            string[] result;

            for (int i = 0; i < ModListBox.Controls.Count; i++)
            {
                if (ModListBox.Controls[i].Controls[1].BackColor == Color.MediumTurquoise)
                {
                    modList.Add(ModListBox.Controls[i].Controls[1].Text);
                }
            }

            result = modList.Distinct().ToArray();

            File.WriteAllLines(_gamePath + _modsPath + "\\mod_load_order.txt", result);
        }
    }
}
