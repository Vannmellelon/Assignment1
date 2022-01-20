using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Items
{
    class Weapon : Item
    {
        public enum WeaponType
        {
            Axe,
            Bow,
            Dagger,
            Hammer,
            Staff,
            Sword,
            Wand
        }

        public WeaponType Type { get; set; }
    }
}
