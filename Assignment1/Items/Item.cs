using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Items
{
    abstract class Item
    {
        public string Name { get; set; }
        public int RequiredLvl { get; set; } // ? set once ig
    }
}
