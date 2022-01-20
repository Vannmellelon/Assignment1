using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Characters
{
    class Ranger : Character
    {
        // Exposing default constructor
        public Ranger()
        {
            Stats.Strength = 1;
            Stats.Dexterity = 7;
            Stats.Intelligence = 1;
        }

        public override void LevelUp()
        {
            Level += 1;
            Stats.Strength += 1;
            Stats.Dexterity += 5;
            Stats.Intelligence += 1;
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

        public override string DisplayCharacterStats()
        {
            throw new NotImplementedException();
        }
    }
}
