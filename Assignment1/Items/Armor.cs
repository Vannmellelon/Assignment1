using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Armor : Item
    {
        public Armor()
        {
            ArmorStats.Strength = 0;
            ArmorStats.Dexterity = 0;
            ArmorStats.Intelligence = 0;
        }
        /// <summary>
        /// Enum for armor types
        /// </summary>
        public enum ArmorType
        {
            Cloth,
            Leather,
            Mail,
            Plate
        }

        // Getters and setters
        public ArmorType Type { get; set; }
        PrimaryAttribute ArmorStats = new();
        public void SetArmorStats(int s, int d, int i)
        {
            ArmorStats.Strength = s;
            ArmorStats.Dexterity = d;
            ArmorStats.Intelligence = i;

        }

        public override PrimaryAttribute GetAttribute()
        {
            return ArmorStats;
        }
    }
}
