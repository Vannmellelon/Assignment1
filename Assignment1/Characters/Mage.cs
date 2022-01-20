using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Mage : Character
    {
        // Exposing default constructor
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
