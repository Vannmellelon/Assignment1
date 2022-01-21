using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Weapon : Item
    {
        /// <summary>
        /// Default constructor assigns slot to WeaponSlot
        /// </summary>
        public Weapon()
        {
            EquipableSlot = Slot.ItemSlot.WeaponSlot;
        }

        /// <summary>
        /// Enum for weapon types
        /// </summary>
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

        // Getters and setters
        public WeaponType Type { get; set; }
        public WeaponAttribute WeaponStats = new();

        /// <summary>
        /// Returns the weapons Damage per second
        /// </summary>
        /// <returns></returns>
        public double DamagePerSecond()
        {
            return WeaponStats.Damage * WeaponStats.AttackSpeed;
        }

        public override PrimaryAttribute GetAttribute()
        {
            return WeaponStats;
        }
    }
}
