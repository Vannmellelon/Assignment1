using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    abstract class Item
    {
        // Enum for Item slots
        public enum ItemSlot
        {
            WeaponSlot,
            HeadSlot,
            BodySlot,
            LegSlot
        };

        public ItemSlot Slot;
        public string Name { get; set; }
        public int RequiredLvl { get; set; }

        /// <summary>
        /// Returns the item's attribute
        /// </summary>
        /// <returns></returns>
        public abstract PrimaryAttribute GetAttribute();

    }
}
