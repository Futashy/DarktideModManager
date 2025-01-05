using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarktideModManager
{
    public class ModItem
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public ModItem(int number, string name, bool isActive)
        {
            Number = number;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            IsActive = isActive;
        }
    }
}
