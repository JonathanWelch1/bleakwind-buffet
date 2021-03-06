﻿/*
 * Author: Zachery Brunner
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class PhillyPoacherTests
    {

        [Fact]
        public void ChangingSirloinNotifiesProperty()
        {
            var pp = new PhillyPoacher();

            Assert.PropertyChanged(pp, "Sirloin", () =>
            {
                pp.Sirloin = false;
            });
            Assert.PropertyChanged(pp, "Sirloin", () =>
            {
                pp.Sirloin = true;
            });
        }

        [Fact]
        public void ChangingOnionNotifiesProperty()
        {
            var pp = new PhillyPoacher();

            Assert.PropertyChanged(pp, "Onion", () =>
            {
                pp.Onion = false;
            });
            Assert.PropertyChanged(pp, "Onion", () =>
            {
                pp.Onion = true;
            });
        }

        [Fact]
        public void ChangingRoll()
        {
            var pp = new PhillyPoacher();

            Assert.PropertyChanged(pp, "Roll", () =>
            {
                pp.Roll = false;
            });
            Assert.PropertyChanged(pp, "Roll", () =>
            {
                pp.Roll = true;
            });
        }

        [Fact]
        public void ShouldBeAEntree()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.IsAssignableFrom<Entree>(pp);
        }

        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.True(pp.Sirloin);

        }

        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.True(pp.Onion);
        }

        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.True(pp.Roll);
        }

        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Sirloin = true;
            Assert.True(pp.Sirloin);
            pp.Sirloin = false;
            Assert.False(pp.Sirloin);
        }

        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Onion = true;
            Assert.True(pp.Onion);
            pp.Onion = false;
            Assert.False(pp.Onion);
        }

        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Roll = true;
            Assert.True(pp.Roll);
            pp.Roll = false;
            Assert.False(pp.Roll);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.Equal(7.23, pp.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.Equal("784", pp.Calories.ToString());
        }

        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Sirloin = includeSirloin;
            pp.Roll = includeRoll;
            pp.Onion = includeOnion;
            if(!pp.Sirloin && !pp.Roll && !pp.Onion)
            {
                Assert.Contains("Hold sirloin", pp.SpecialInstructions);
                Assert.Contains("Hold roll", pp.SpecialInstructions);
                Assert.Contains("Hold onion", pp.SpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.Contains("Philly Poacher", pp.ToString());
        }
    }
}