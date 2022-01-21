using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Armor : Item
    {
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

        public override PrimaryAttribute GetAttribute()
        {
            return ArmorStats;
        }
    }
}
