using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Weapon : Item
    {
        /// <summary>
        /// Default constructor assigns slot to WeaponSlot
        /// </summary>
        public Weapon()
        {
            EquipableSlot = Slot.ItemSlot.WeaponSlot;

            WeaponStats.Strength = 0;
            WeaponStats.Dexterity = 0;
            WeaponStats.Intelligence = 0;

            WeaponStats.Damage = 0;
            WeaponStats.AttackSpeed = 0.0;
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


        public void SetWeaponStats(int s, int d, int i, int dam, double atkSpd)
        {
            WeaponStats.Strength = s;
            WeaponStats.Dexterity = d;
            WeaponStats.Intelligence = i;

            WeaponStats.Damage = dam;
            WeaponStats.AttackSpeed = atkSpd;
        }

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
