using System;

namespace Assignment1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello RPG!");

			PrimaryAttribute testAttributes = new PrimaryAttribute();
			testAttributes.Strength = 9;
			PrimaryAttribute testAttributes2 = new PrimaryAttribute();
			testAttributes2.Strength = 8;
			PrimaryAttribute primaryAttribute3 = testAttributes + testAttributes2;
            Console.WriteLine(primaryAttribute3.Strength);


			Mage Yen = new Mage();
			Yen.Name = "Yen";
            Console.WriteLine(Yen.Name);
			Console.WriteLine(Yen.Stats.Intelligence);
			Yen.LevelUp();
            Console.WriteLine(Yen.Stats.Intelligence);
            Console.WriteLine(Yen.Level);

            Console.WriteLine(Yen.DisplayCharacterStats());

			Weapon testWpn = new Weapon()
			{
				Name = "En øks",
				RequiredLvl = 1,
				//Slot = Item.ItemSlot.WeaponSlot,
				Type = Weapon.WeaponType.Axe,
				//WeaponStats.Damage = 7,
				//WeaponStats.AttackSpeed = 1.1
			};

		}
	}
}
