﻿/*
 * Author: Zachery Brunner
 * Class: VokunSaladTests.cs
 * Purpose: Test the VokunSalad.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class VokunSaladTests
    {
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingSizeShouldNotifyStuff(Size size)
        {
            var vs = new VokunSalad();
            if (size == Size.Small) { vs.Size = Size.Medium; }
            Assert.PropertyChanged(vs, "Size", () =>
            {
                vs.Size = size;
            });

        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingPriceShouldNotifyStuff(Size size)
        {
            var vs = new VokunSalad();
            if (size == Size.Small) { vs.Size = Size.Medium; }
            Assert.PropertyChanged(vs, "Price", () =>
            {
                vs.Size = size;
            });

        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ChangingCaloriesShouldNotifyStuff(Size size)
        {
            var vs = new VokunSalad(); ;
            if (size == Size.Small) { vs.Size = Size.Medium; }
            Assert.PropertyChanged(vs, "Calories", () =>
            {
                vs.Size = size;
            });

        }
        [Fact]
        public void ShouldBeASide()
        {
            VokunSalad vs = new VokunSalad();
            Assert.IsAssignableFrom<Side>(vs);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            VokunSalad vs = new VokunSalad();
            Assert.Equal(Size.Small, vs.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            VokunSalad vs = new VokunSalad();
            vs.Size = Size.Large;
            Assert.Equal(Size.Large, vs.Size);
            vs.Size = Size.Medium;
            Assert.Equal(Size.Medium, vs.Size);
            vs.Size = Size.Small;
            Assert.Equal(Size.Small, vs.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            VokunSalad vs = new VokunSalad();
            Assert.Empty(vs.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.93)]
        [InlineData(Size.Medium, 1.28)]
        [InlineData(Size.Large, 1.82)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            VokunSalad vs = new VokunSalad();
            vs.Size = size;
            Assert.Equal(price, vs.Price);
        }

        [Theory]
        [InlineData(Size.Small, 41)]
        [InlineData(Size.Medium, 52)]
        [InlineData(Size.Large, 73)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            VokunSalad vs = new VokunSalad();
            vs.Size = size;
            Assert.Equal(calories, vs.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Vokun Salad")]
        [InlineData(Size.Medium, "Medium Vokun Salad")]
        [InlineData(Size.Large, "Large Vokun Salad")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            VokunSalad vs = new VokunSalad();
            vs.Size = size;
            Assert.Equal(name, vs.ToString());
        }
    }
}