/*
 * Author: Zachery Brunner
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class DragonbornWaffleFriesTests
    {

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldNotifyStuff(Size size)
        {
            var df = new DragonbornWaffleFries();
            if (size == Size.Small) { df.Size = Size.Medium; }
            Assert.PropertyChanged(df, "Size", () =>
            {
                df.Size = size;
            });

        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingPriceShouldNotifyStuff(Size size)
        {
            var df = new DragonbornWaffleFries();
            if (size == Size.Small) { df.Size = Size.Medium; }
            Assert.PropertyChanged(df, "Price", () =>
            {
                df.Size = size;
            });

        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingCaloriesShouldNotifyStuff(Size size)
        {
            var df = new DragonbornWaffleFries();
            if (size == Size.Small) { df.Size = Size.Medium; }
            Assert.PropertyChanged(df, "Calories", () =>
            {
                df.Size = size;
            });

        }
        [Fact]
        public void ShouldBeASide()
        {
            DragonbornWaffleFries df = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<Side>(df);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            DragonbornWaffleFries df = new DragonbornWaffleFries();
            Assert.Equal(Size.Small, df.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            DragonbornWaffleFries df = new DragonbornWaffleFries();
            df.Size = Size.Large;
            Assert.Equal(Size.Large, df.Size);
            df.Size = Size.Medium;
            Assert.Equal(Size.Medium, df.Size);
            df.Size = Size.Small;
            Assert.Equal(Size.Small, df.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            DragonbornWaffleFries df = new DragonbornWaffleFries();
            Assert.Empty(df.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.42)]
        [InlineData(Size.Medium, 0.76)]
        [InlineData(Size.Large, 0.96)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            DragonbornWaffleFries df = new DragonbornWaffleFries();
            df.Size = size;
            Assert.Equal(price, df.Price);
        }

        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            DragonbornWaffleFries df = new DragonbornWaffleFries();
            df.Size = size;
            Assert.Equal(calories, df.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            DragonbornWaffleFries df = new DragonbornWaffleFries();
            df.Size = size;
            Assert.Equal(name, df.ToString());
        }
    }
}