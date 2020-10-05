/*
 * Author: Zachery Brunner
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class BriarheartBurgerTests
    {
        [Fact]
        public void ChangingCheeseNotifiesProperty()
        {
            var BB = new BriarheartBurger();

            Assert.PropertyChanged(BB, "Cheese", () =>
            {
                BB.Cheese = false;
            });
            Assert.PropertyChanged(BB, "Cheese", () =>
            {
                BB.Cheese = true;
            });
        }

        [Fact]
        public void ChangingPickleNotifiesProperty()
        {
            var BB = new BriarheartBurger();

            Assert.PropertyChanged(BB, "Pickle", () =>
            {
                BB.Pickle = false;
            });
            Assert.PropertyChanged(BB, "Pickle", () =>
            {
                BB.Pickle = true;
            });
        }

        [Fact]
        public void ChangingMustardNotifiesProperty()
        {
            var BB = new BriarheartBurger();

            Assert.PropertyChanged(BB, "Mustard", () =>
            {
                BB.Mustard = false;
            });
            Assert.PropertyChanged(BB, "Mustard", () =>
            {
                BB.Mustard = true;
            });
        }
        [Fact]
        public void ChangingBunNotifiesProperty()
        {
            var BB = new BriarheartBurger();

            Assert.PropertyChanged(BB, "Bun", () =>
            {
                BB.Bun = false;
            });
            Assert.PropertyChanged(BB, "Bun", () =>
            {
                BB.Bun = true;
            });
        }
        [Fact]
        public void ChangingKetchupNotifiesProperty()
        {
            var BB = new BriarheartBurger();

            Assert.PropertyChanged(BB, "Ketchup", () =>
            {
                BB.Ketchup = false;
            });
            Assert.PropertyChanged(BB, "Ketchup", () =>
            {
                BB.Ketchup = true;
            });
        }
        [Fact]
        public void ShouldBeAEntree()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.IsAssignableFrom<Entree>(bb);
        }
        
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.True(bb.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Bun = true;
            Assert.True(bb.Bun);
            bb.Bun = false;
            Assert.False(bb.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Ketchup = true;
            Assert.True(bb.Ketchup);
            bb.Ketchup = false;
            Assert.False(bb.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Mustard = true;
            Assert.True(bb.Mustard);
            bb.Mustard = false;
            Assert.False(bb.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Pickle = true;
            Assert.True(bb.Pickle);
            bb.Pickle = false;
            Assert.False(bb.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Cheese = true;
            Assert.True(bb.Cheese);
            bb.Cheese = false;
            Assert.False(bb.Cheese);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.Equal(6.32, bb.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.Equal("743", bb.Calories.ToString());
        }

        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese)
        {
            BriarheartBurger bb = new BriarheartBurger();
            bb.Bun = includeBun;
            bb.Ketchup = includeKetchup;
            bb.Mustard = includeMustard;
            bb.Pickle = includePickle;
            bb.Cheese = includeCheese;
            if (!bb.Bun && !bb.Ketchup && !bb.Mustard && !bb.Pickle && !bb.Cheese)
            {
                Assert.Contains("Hold bun", bb.SpecialInstructions);
                Assert.Contains("Hold ketchup", bb.SpecialInstructions);
                Assert.Contains("Hold mustard", bb.SpecialInstructions);
                Assert.Contains("Hold pickle", bb.SpecialInstructions);
                Assert.Contains("Hold cheese", bb.SpecialInstructions);
            }
            else
            {
                Assert.Empty(bb.SpecialInstructions);
            }
            
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.Contains("Briarheart Burger", bb.ToString());
        }
    }
}