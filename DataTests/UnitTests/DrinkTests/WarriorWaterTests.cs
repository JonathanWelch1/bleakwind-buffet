using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using NuGet.Frameworks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class WarriorWaterTests
    {

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldNotifyStuff(Size size)
        {
            var WW = new WarriorWater();
            if (size == Size.Small) { WW.Size = Size.Medium; }
            Assert.PropertyChanged(WW, "Size", () =>
            {
                WW.Size = size;
            });

        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingPriceShouldNotifyStuff(Size size)
        {
            var WW = new WarriorWater();
            if (size == Size.Small) { WW.Size = Size.Medium; }
            Assert.PropertyChanged(WW, "Price", () =>
            {
                WW.Size = size;
            });

        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingCaloriesShouldNotifyStuff(Size size)
        {
            var WW = new WarriorWater();
            if (size == Size.Small) { WW.Size = Size.Medium; }
            Assert.PropertyChanged(WW, "Calories", () =>
            {
                WW.Size = size;
            });

        }
        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var WW = new WarriorWater();

            Assert.PropertyChanged(WW, "Ice", () =>
            {
                WW.Ice = false;
            });
            Assert.PropertyChanged(WW, "Ice", () =>
            {
                WW.Ice = true;
            });
        }

        [Fact]
        public void ChangingLemonNotifiesLemonProperty()
        {
            var WW = new WarriorWater();

            Assert.PropertyChanged(WW, "Lemon", () =>
            {
                WW.Lemon = true;
            });
            Assert.PropertyChanged(WW, "Lemon", () =>
            {
                WW.Lemon = false;
            });
        }
        [Fact]
        public void ShouldBeADrink()
        {
            WarriorWater ww = new WarriorWater();
            Assert.IsAssignableFrom<Drink>(ww);
        }

        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.True(ww.Ice);
        }

        [Fact]
        public void ShouldNotIncludeLemonByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.False(ww.Lemon);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.Equal(Size.Small, ww.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            WarriorWater ww = new WarriorWater();
            ww.Ice = true;
            Assert.True(ww.Ice);
            ww.Ice = false;
            Assert.False(ww.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = Size.Large;
            Assert.Equal(Size.Large, ww.Size);
            ww.Size = Size.Medium;
            Assert.Equal(Size.Medium, ww.Size);
            ww.Size = Size.Small;
            Assert.Equal(Size.Small, ww.Size);
        }


        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(price, ww.Price);
        }

        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(cal, ww.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(false, false)]
        [InlineData(false, true)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            WarriorWater ww = new WarriorWater();
            ww.Ice = includeIce;
            ww.Lemon = includeLemon;
            if(includeIce && includeLemon)
            {
                Assert.Contains("Add Lemon", ww.SpecialInstructions);
            }
            else if(!includeIce && includeLemon)
            {
                Assert.Contains("Add Lemon", ww.SpecialInstructions);
                Assert.Contains("Hold Ice", ww.SpecialInstructions);
            }
            else
            {
                Assert.Contains("Hold Ice",ww.SpecialInstructions);
            }

        }

        [Theory]
        [InlineData( Size.Small, "Small Warrior Water")]
        [InlineData( Size.Medium, "Medium Warrior Water")]
        [InlineData( Size.Large, "Large Warrior Water")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(name, ww.ToString());
        }


    }
}
