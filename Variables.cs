using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarktideModManager
{
    public partial class MainWindow : Form
    {
        public List<ModItem> modList;

        private string _gamePath = "";
        private string _modsPath = "\\mods";

        private string[] _ignoredList = { "base", "dmf" };

        private bool isInDebug = false;
    }
}
