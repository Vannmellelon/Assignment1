using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class InvalidWeaponException : Exception
    {
        public override string Message => "The Weapon is invalid.";
    }
}
