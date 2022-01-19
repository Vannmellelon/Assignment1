using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Mage : Character
    {
        // Setting default stats
        PrimaryAttribute Stats = new PrimaryAttribute
        {
            Strength = 1,
            Dexterity = 1,
            Intelligence = 8
        };

        public override void LevelUp()
        {
            Level += 1;
            Stats.Strength += 1;
            Stats.Dexterity += 1;
            Stats.Intelligence += 5;
        }

        public override void Damage()
        {
            throw new NotImplementedException();
        }

        public override int GetBaseTotalAttributes()
        {
            return Stats.Strength + Stats.Dexterity + Stats.Intelligence;
        }

        public override int GetTotalAttributes()
        {
            return GetBaseTotalAttributes(); // pluss!! ItemTotalAttributes() ig
        }

    }
}
