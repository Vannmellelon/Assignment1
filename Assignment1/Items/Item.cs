using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    abstract class Item
    {
        public Slot.ItemSlot EquipableSlot;
        public string Name { get; set; }
        public int RequiredLvl { get; set; }

        /// <summary>
        /// Returns the item's attribute
        /// </summary>
        /// <returns></returns>
        public abstract PrimaryAttribute GetAttribute();

    }
}
