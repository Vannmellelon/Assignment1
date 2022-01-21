using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Warrior : Character
    {
        /// <summary>
        /// Sets the Warrior's lvl.1 stats
        /// </summary>
        public Warrior()
        {
            Stats.Strength = 5;
            Stats.Dexterity = 2;
            Stats.Intelligence = 1;
        }

        public override void LevelUp()
        {
            Level += 1;
            Stats.Strength += 3;
            Stats.Dexterity += 2;
            Stats.Intelligence += 1;
        }

        public override double Damage()
        {
            Weapon wpn = (Weapon)Equipment.GetValueOrDefault(Item.ItemSlot.WeaponSlot);
            if (wpn == null) return 1;

            double damage = wpn.DamagePerSecond() * (1 + GetTotalAttributes().Strength / 100);

            return damage;
        }

        public override void Equip(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
