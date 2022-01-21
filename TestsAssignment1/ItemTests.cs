using System;
using Xunit;
using Assignment1;

namespace TestsAssignment1
{
    public class ItemTests
    {

        // Arranging Items

        Weapon testAxe = new Weapon()
        {
            Name = "Øks",
            RequiredLvl = 1,
            // ItemSlot = WeaponSlot is set in the constructor of Weapon
            Type = Weapon.WeaponType.Axe,
        };

        [Fact]
        public void Test1()
        {

        }
    }
}
