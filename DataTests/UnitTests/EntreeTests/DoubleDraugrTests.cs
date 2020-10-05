﻿/*
 * Author: Zachery Brunner
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class DoubleDraugrTests
    {

        [Fact]
        public void ChangingCheeseNotifiesProperty()
        {
            var dd = new DoubleDraugr();

            Assert.PropertyChanged(dd, "Cheese", () =>
            {
                dd.Cheese = false;
            });
            Assert.PropertyChanged(dd, "Cheese", () =>
            {
                dd.Cheese = true;
            });
        }
        [Fact]
        public void ChangingPickleNotifiesProperty()
        {
            var dd = new DoubleDraugr();

            Assert.PropertyChanged(dd, "Pickle", () =>
            {
                dd.Pickle = false;
            });
            Assert.PropertyChanged(dd, "Pickle", () =>
            {
                dd.Pickle = true;
            });
        }
        [Fact]
        public void ChangingMustardNotifiesProperty()
        {
            var DD = new DoubleDraugr();

            Assert.PropertyChanged(DD, "Mustard", () =>
            {
                DD.Mustard = false;
            });
            Assert.PropertyChanged(DD, "Mustard", () =>
            {
                DD.Mustard = true;
            });
        }
        [Fact]
        public void ChangingBunNotifiesProperty()
        {
            var dd = new DoubleDraugr();

            Assert.PropertyChanged(dd, "Bun", () =>
            {
                dd.Bun = false;
            });
            Assert.PropertyChanged(dd, "Bun", () =>
            {
                dd.Bun = true;
            });
        }
        [Fact]
        public void ChangingKetchupNotifiesProperty()
        {
            var dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Ketchup", () =>
            {
                dd.Ketchup = false;
            });
            Assert.PropertyChanged(dd, "Ketchup", () =>
            {
                dd.Ketchup = true;
            });
        }
        [Fact]
        public void ChangingTomatoNotifiesProperty()
        {
            var dd = new DoubleDraugr();

            Assert.PropertyChanged(dd, "Tomato", () =>
            {
                dd.Tomato = false;
            });
            Assert.PropertyChanged(dd, "Tomato", () =>
            {
                dd.Tomato = true;
            });
        }
        [Fact]
        public void ChangingMayoNotifiesProperty()
        {
            var dd = new DoubleDraugr();

            Assert.PropertyChanged(dd, "Mayo", () =>
            {
                dd.Mayo = false;
            });
            Assert.PropertyChanged(dd, "Mayo", () =>
            {
                dd.Mayo = true;
            });
        }
        [Fact]
        public void ChangingLettuceNotifiesProperty()
        {
            var dd = new DoubleDraugr();

            Assert.PropertyChanged(dd, "Lettuce", () =>
            {
                dd.Lettuce = false;
            });
            Assert.PropertyChanged(dd, "Lettuce", () =>
            {
                dd.Lettuce = true;
            });
        }
        [Fact]
        public void ShouldBeAEntree()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.IsAssignableFrom<Entree>(dd);
        }

        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Bun = true;
            Assert.True(dd.Bun);
            dd.Bun = false;
            Assert.False(dd.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Ketchup = true;
            Assert.True(dd.Ketchup);
            dd.Ketchup = false;
            Assert.False(dd.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Mustard = true;
            Assert.True(dd.Mustard);
            dd.Mustard = false;
            Assert.False(dd.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Pickle = true;
            Assert.True(dd.Pickle);
            dd.Pickle = false;
            Assert.False(dd.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Cheese = true;
            Assert.True(dd.Cheese);
            dd.Cheese = false;
            Assert.False(dd.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Tomato = true;
            Assert.True(dd.Tomato);
            dd.Tomato = false;
            Assert.False(dd.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Lettuce = true;
            Assert.True(dd.Lettuce);
            dd.Lettuce = false;
            Assert.False(dd.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Mayo = true;
            Assert.True(dd.Mayo);
            dd.Mayo = false;
            Assert.False(dd.Mayo);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal(7.32, dd.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal("843", dd.Calories.ToString());
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {

            DoubleDraugr dd = new DoubleDraugr();
            dd.Bun = includeBun;
            dd.Ketchup = includeKetchup;
            dd.Mustard = includeMustard;
            dd.Pickle = includePickle;
            dd.Cheese = includeCheese;
            dd.Tomato = includeTomato;
            dd.Lettuce = includeLettuce;
            dd.Mayo = includeMayo;
            if(!dd.Bun && !dd.Ketchup && !dd.Mustard && !dd.Pickle && !dd.Cheese && !dd.Tomato && !dd.Lettuce && !dd.Mayo)
            {
                Assert.Contains("Hold bun", dd.SpecialInstructions);
                Assert.Contains("Hold ketchup", dd.SpecialInstructions);
                Assert.Contains("Hold mustard", dd.SpecialInstructions);
                Assert.Contains("Hold pickle", dd.SpecialInstructions);
                Assert.Contains("Hold cheese", dd.SpecialInstructions);
                Assert.Contains("Hold tomato", dd.SpecialInstructions);
                Assert.Contains("Hold lettuce", dd.SpecialInstructions);
                Assert.Contains("Hold mayo", dd.SpecialInstructions);
            }
            else
            {
                Assert.Empty(dd.SpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Contains("Double Draugr", dd.ToString());
        }
    }
}