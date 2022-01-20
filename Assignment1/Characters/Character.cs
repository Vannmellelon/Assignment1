using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    abstract class Character
    {
        public string Name { get; set; }
        public int Level { get; set; } = 1;

        public PrimaryAttribute Stats = new();


        public abstract void LevelUp();
        public abstract void Damage();
        // add all stats from levelling namechange
        public abstract int GetBaseTotalAttributes();
        // add all stats including equipment osv, namechange
        public abstract int GetTotalAttributes();
        // Character stats display, name, level, stats + gear bonuses, damage
        public abstract string DisplayCharacterStats();
    }
}
