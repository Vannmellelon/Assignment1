using System;
using Xunit;
using Assignment1;

namespace TestsAssignment1
{
    public class CharacterTests
    {
        [Fact]
        public void CharacterCreation_Normal_ShouldBeLvl1()
        {
            // Arrange 
            Mage Yen = new Mage();
            int lvl = Yen.Level;
            int expectedLvl = 1;
            // Assert
            Assert.True(lvl == expectedLvl);
        }

        [Fact]
        public void CharacterCreation_LevelUp_ShouldBeLvl2()
        {
            // Arrange 
            Mage Yen = new Mage();
            // Act
            Yen.LevelUp();
            int lvl = Yen.Level;
            int expectedLvl = 2;
            // Assert
            Assert.True(lvl == expectedLvl);
        }

        // Normal lvl.1 stats for all classes
        [Fact]
        public void CharacterCreation_Normal_MageStats()
        {
            // Arrange 
            Mage Yen = new Mage();
            PrimaryAttribute stats = Yen.Stats;
            PrimaryAttribute expectedStats = new PrimaryAttribute()
            {
                Strength = 1,
                Dexterity = 1,
                Intelligence = 8
            };
            // Assert
            Assert.True(
                stats.Strength == expectedStats.Strength &&
                stats.Dexterity == expectedStats.Dexterity &&
                stats.Intelligence == expectedStats.Intelligence);
        }

        [Fact]
        public void CharacterCreation_Normal_RangerStats()
        {
            // Arrange 
            Ranger Robin = new Ranger();
            PrimaryAttribute stats = Robin.Stats;
            PrimaryAttribute expectedStats = new PrimaryAttribute()
            {
                Strength = 1,
                Dexterity = 7,
                Intelligence = 1
            };
            // Assert
            Assert.True(
                stats.Strength == expectedStats.Strength &&
                stats.Dexterity == expectedStats.Dexterity &&
                stats.Intelligence == expectedStats.Intelligence);
        }

        [Fact]
        public void CharacterCreation_Normal_RougeStats()
        {
            // Arrange 
            Rouge Sly = new Rouge();
            PrimaryAttribute stats = Sly.Stats;
            PrimaryAttribute expectedStats = new PrimaryAttribute()
            {
                Strength = 2,
                Dexterity = 6,
                Intelligence = 1
            };
            // Assert
            Assert.True(
                stats.Strength == expectedStats.Strength &&
                stats.Dexterity == expectedStats.Dexterity &&
                stats.Intelligence == expectedStats.Intelligence);
        }

        [Fact]
        public void CharacterCreation_Normal_WarriorStats()
        {
            // Arrange 
            Warrior Vi = new Warrior();
            PrimaryAttribute stats = Vi.Stats;
            PrimaryAttribute expectedStats = new PrimaryAttribute()
            {
                Strength = 5,
                Dexterity = 2,
                Intelligence = 1
            };
            // Assert
            Assert.True(
                stats.Strength == expectedStats.Strength &&
                stats.Dexterity == expectedStats.Dexterity &&
                stats.Intelligence == expectedStats.Intelligence);
        }

        // Expected lvl.2 stats after levveling up for all classes

        [Fact]
        public void CharacterCreation_LevelUp_MageStats()
        {
            // Arrange 
            Mage Yen = new Mage();
            PrimaryAttribute expectedStats = new PrimaryAttribute()
            {
                Strength = 2,
                Dexterity = 2,
                Intelligence = 13
            };
            // Act
            Yen.LevelUp();
            PrimaryAttribute stats = Yen.Stats;
            // Assert
            Assert.True(
                stats.Strength == expectedStats.Strength &&
                stats.Dexterity == expectedStats.Dexterity &&
                stats.Intelligence == expectedStats.Intelligence);
        }

        [Fact]
        public void CharacterCreation_LevelUp_RangerStats()
        {
            // Arrange 
            Ranger Robin = new Ranger();
            PrimaryAttribute expectedStats = new PrimaryAttribute()
            {
                Strength = 2,
                Dexterity = 12,
                Intelligence = 2
            };
            // Act
            Robin.LevelUp();
            PrimaryAttribute stats = Robin.Stats;
            // Assert
            Assert.True(
                stats.Strength == expectedStats.Strength &&
                stats.Dexterity == expectedStats.Dexterity &&
                stats.Intelligence == expectedStats.Intelligence);
        }

        [Fact]
        public void CharacterCreation_LevelUp_RougeStats()
        {
            // Arrange 
            Rouge Sly = new Rouge();

            PrimaryAttribute expectedStats = new PrimaryAttribute()
            {
                Strength = 3,
                Dexterity = 10,
                Intelligence = 2
            };
            // Act
            Sly.LevelUp();
            PrimaryAttribute stats = Sly.Stats;
            // Assert
            Assert.True(
                stats.Strength == expectedStats.Strength &&
                stats.Dexterity == expectedStats.Dexterity &&
                stats.Intelligence == expectedStats.Intelligence);
        }

        [Fact]
        public void CharacterCreation_LevelUp_WarriorStats()
        {
            // Arrange 
            Warrior Vi = new Warrior();

            PrimaryAttribute expectedStats = new PrimaryAttribute()
            {
                Strength = 8,
                Dexterity = 4,
                Intelligence = 2
            };
            // Act
            Vi.LevelUp();
            PrimaryAttribute stats = Vi.Stats;
            // Assert
            Assert.True(
                stats.Strength == expectedStats.Strength &&
                stats.Dexterity == expectedStats.Dexterity &&
                stats.Intelligence == expectedStats.Intelligence);
        }
    }
}
