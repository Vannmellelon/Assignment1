using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Mage : Character
    {
        /// <summary>
        /// Sets the Mage's lvl.1 stats
        /// </summary>
        public Mage()
        { 
            Stats.Strength = 1; 
            Stats.Dexterity = 1;
            Stats.Intelligence = 8;
        }

        public override void LevelUp()
        {
            Level += 1;
            Stats.Strength += 1;
            Stats.Dexterity += 1;
            Stats.Intelligence += 5;
        }

        public override double Damage()
        {
            Weapon wpn = (Weapon)Equipment.GetValueOrDefault(Slot.ItemSlot.WeaponSlot);
            if (wpn == null) return 1;
            
            double damage = wpn.DamagePerSecond() * (1 + GetTotalAttributes().Intelligence / 100);

            return damage;
        }

        public override bool CheckIfCanEquipArmor(Armor armor)
        {
            if (armor.Type == Armor.ArmorType.Cloth) return true;
            else return false;
        }

        public override bool CheckIfCanEquipWeapon(Weapon weapon)
        {
            if (weapon.Type == Weapon.WeaponType.Staff || weapon.Type == Weapon.WeaponType.Staff) return true;
            else return false;
        }
    }
}
