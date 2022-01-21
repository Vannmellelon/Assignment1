using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Rouge : Character
    {
        /// <summary>
        /// Sets the Rouge's lvl.1 stats
        /// </summary>
        public Rouge()
        {
            Stats.Strength = 2;
            Stats.Dexterity = 6;
            Stats.Intelligence = 1;
        }

        public override void LevelUp()
        {
            Level += 1;
            Stats.Strength += 1;
            Stats.Dexterity += 4;
            Stats.Intelligence += 1;
        }

        public override double Damage()
        {
            Weapon wpn = (Weapon)Equipment.GetValueOrDefault(Item.ItemSlot.WeaponSlot);
            if (wpn == null) return 1;

            double damage = wpn.DamagePerSecond() * (1 + GetTotalAttributes().Dexterity / 100);

            return damage;
        }

        public override void Equip(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
