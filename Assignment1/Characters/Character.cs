using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    abstract class Character
    {
        // Getters and Setters
        public string Name { get; set; }
        public int Level { get; set; } = 1;

        public PrimaryAttribute Stats = new();
        public Dictionary<Slot.ItemSlot, Item> Equipment = new();


        /// <summary>
        /// Levels up the character, adds to their stats based on their class
        /// </summary>
        public abstract void LevelUp();

        /// <summary>
        /// Uses the characters' stats and equipment to calculate their damage output
        /// </summary>
        public abstract double Damage();

        /// <summary>
        /// Equips a given piece of armor in the correct slot
        /// </summary>
        /// <param name="armor"></param>
        public virtual void EquipArmor(Armor armor)
        {
            Slot.ItemSlot _slot = armor.EquipableSlot;
            if (CheckIfCanEquipArmor(armor)) Equipment[_slot] = armor;
            // else Exception();
        }

        /// <summary>
        /// Equips a given weapon in the correct slot
        /// </summary>
        /// <param name="weapon"></param>
        public virtual void EquipWeapon(Weapon weapon)
        {
            if (CheckIfCanEquipWeapon(weapon)) Equipment[Slot.ItemSlot.WeaponSlot] = weapon;
            // else Exception();
        }

        /// <summary>
        /// Checks if the armor is of a type that the character can equip
        /// </summary>
        /// <param name="armor"></param>
        /// <returns></returns>
        public abstract bool CheckIfCanEquipArmor(Armor armor);

        /// <summary>
        /// Checks if the weapon is of a type that the character can equip
        /// </summary>
        /// <param name="weapon"></param>
        /// <returns></returns>
        public abstract bool CheckIfCanEquipWeapon(Weapon weapon);

        /// <summary>
        /// Adds up all stats of a character including equipment
        /// </summary>
        /// <returns>stat total</returns>
        public virtual PrimaryAttribute GetTotalAttributes()
        {
            return Stats + GetTotalEqiupmentAttributes();
        }

        /// <summary>
        /// Adds upp all stats of character's equpment
        /// </summary>
        /// <returns></returns>
        public virtual PrimaryAttribute GetTotalEqiupmentAttributes()
        {
            PrimaryAttribute total = new();
            foreach (KeyValuePair<Slot.ItemSlot, Item> entry in Equipment)
            {
                total = total + entry.Value.GetAttribute();
            }
            return total;
        }

        /// <summary>
        /// Returns the character's stats added up
        /// </summary>
        /// <returns></returns>
        public virtual int GetStatTotal()
        {
            return Stats.Strength + Stats.Dexterity + Stats.Intelligence;
        }
        /// <summary>
        /// Returns a string with a characters stats, name, level, stats + gear bonuses and damage
        /// </summary>
        /// <returns></returns>
        public virtual string DisplayCharacterStats()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name:\t" + Name);
            sb.Append("\nClass:\t" + this.GetType().Name);
            sb.Append("\nLevel:\t" + Level.ToString());
            // Base stats
            sb.Append("\nBase Stats:");
            sb.Append("\n\nStrength:\t" + Stats.Strength.ToString());
            sb.Append("\nDexterity:\t" + Stats.Dexterity.ToString());
            sb.Append("\nIntelligence:\t" + Stats.Intelligence.ToString());
            sb.Append("\nStat total:\t" + this.GetStatTotal().ToString());
            // Stats from gear
            sb.Append("\nStats with equipment bonuses:");
            sb.Append("\n\nStrength:\t" + this.GetTotalAttributes().Strength.ToString());
            sb.Append("\nDexterity:\t" + this.GetTotalAttributes().Dexterity.ToString());
            sb.Append("\nIntelligence:\t" + this.GetTotalAttributes().Intelligence.ToString());
            sb.Append("\nStat total:\t" + (this.GetTotalAttributes().Strength + this.GetTotalAttributes().Dexterity + this.GetTotalAttributes().Intelligence).ToString());
            return sb.ToString();
        }
    }
}
