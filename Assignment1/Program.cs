using System;

namespace Assignment1
{
	public class Program
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
            Console.WriteLine(Yen.DisplayCharacterStats());
			Yen.LevelUp();
			Console.WriteLine(Yen.DisplayCharacterStats());

			Weapon staffForYen = new Weapon()
			{
				Name = "Stav",
				RequiredLvl = 1,
				Type = Weapon.WeaponType.Staff
			};
			staffForYen.SetWeaponStats(0, 0, 5, 3, 2.3);
			Yen.EquipWeapon(staffForYen);
			Console.WriteLine(Yen.DisplayCharacterStats());

			Armor armorForYen = new Armor()
			{
				Name = "Kappe",
				RequiredLvl = 2,
				Type = Armor.ArmorType.Cloth,
				EquipableSlot = Slot.ItemSlot.BodySlot
			};
			armorForYen.SetArmorStats(0, 1, 3);
			Yen.EquipArmor(armorForYen);
			Console.WriteLine(Yen.DisplayCharacterStats());
		}
	}
}
