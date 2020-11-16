/*
 * Author: Jonathan Welch
 * Class: MenuTests.cs
 * Purpose: Test the Menutests.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data;
using System.Collections.Generic;

namespace BleakwindBuffet.DataTests.UnitTests.MenuTests
{
    public class MenuTests
    {
        [Fact]
        public void ShouldContainEntrees()
        { 
            Assert.Contains(Menu.Entrees(), (item) => { return item is BriarheartBurger; });
            Assert.Contains(Menu.Entrees(), (item) => { return item is DoubleDraugr; });
            Assert.Contains(Menu.Entrees(), (item) => { return item is GardenOrcOmelette; });
            Assert.Contains(Menu.Entrees(), (item) => { return item is PhillyPoacher; });
            Assert.Contains(Menu.Entrees(), (item) => { return item is SmokehouseSkeleton; });
            Assert.Contains(Menu.Entrees(), (item) => { return item is ThalmorTriple; });
            Assert.Contains(Menu.Entrees(), (item) => { return item is ThugsTBone; });
        }

        [Fact]
        public void ShouldContainDrinks()
        {
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Warrior Water"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Warrior Water"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Warrior Water"); });

            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Aretino Apple Juice"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Aretino Apple Juice"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Aretino Apple Juice"); });

            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Candlehearth Coffee"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Candlehearth Coffee"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Candlehearth Coffee"); });

            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Markarth Milk"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Markarth Milk"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Markarth Milk"); });

            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Cherry Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Cherry Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Cherry Sailor Soda"); });

            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Grapefruit Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Grapefruit Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Grapefruit Sailor Soda"); });

            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Lemon Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Lemon Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Lemon Sailor Soda"); });

            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Peach Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Peach Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Peach Sailor Soda"); });

            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Watermelon Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Watermelon Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Watermelon Sailor Soda"); });
        }

        [Fact]
        public void ShouldContainASide()
        {

            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Small Dragonborn Waffle Fries"); });
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Medium Dragonborn Waffle Fries"); });
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Large Dragonborn Waffle Fries"); });

            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Small Fried Miraak"); });
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Medium Fried Miraak"); });
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Large Fried Miraak"); });

            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Small Mad Otar Grits"); });
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Medium Mad Otar Grits"); });
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Large Mad Otar Grits"); });

            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Small Vokun Salad"); });
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Medium Vokun Salad"); });
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Large Vokun Salad"); });
        }

        [Fact]
        public void ShouldContainFullMenu()
        {
            Assert.Contains(Menu.Sides(), (item) => { return item is Side; });
            Assert.Contains(Menu.Drinks(), (item) => { return item is Drink; });
            Assert.Contains(Menu.Entrees(), (item) => { return item is Entree; });
        }


        [Fact]
        public void ShouldCheckMaxNullCalorieFilter()
        {
            IEnumerable<IOrderItem> temp = Menu.Search("");
            IEnumerable<IOrderItem> search = Menu.Calories(temp, 800, null);
            Assert.Contains(search, (item) => { return item is DoubleDraugr;  });
            Assert.Contains(search, (item) => { return item is ThalmorTriple; });
            Assert.Contains(search, (item) => { return item is ThugsTBone; });

        }

        [Theory]
        [InlineData(600, 800)]
        public void ShouldReturnCorrectResultsForCalories(int? min, int? max)
        {
            IEnumerable<IOrderItem> temp = Menu.Search("");
            IEnumerable<IOrderItem> search = Menu.Calories(temp, min, max);
            Assert.Contains(search, (item) => { return item is BriarheartBurger; });
            Assert.Contains(search, (item) => { return item is PhillyPoacher; });
            Assert.Contains(search, (item) => { return item is SmokehouseSkeleton; });
        }

        [Fact]
        public void ShouldCheckPrice()
        {
            IEnumerable<IOrderItem> temp = Menu.Search("");
            IEnumerable<IOrderItem> search = Menu.Calories(temp, null, null);
            Assert.Contains(search, (item) => { return item is BriarheartBurger; });
        }

        [Fact]
        public void ShouldCheckMin()
        {
            IEnumerable<IOrderItem> temp = Menu.Search("");
            IEnumerable<IOrderItem> search = Menu.Calories(temp, null, 2);
            Assert.Contains(search, (item) => { return item.ToString().Equals("Small Warrior Water"); });
            Assert.Contains(search, (item) => { return item.ToString().Equals("Medium Warrior Water"); });
            Assert.Contains(search, (item) => { return item.ToString().Equals("Large Warrior Water"); });

            Assert.Contains(search, (item) => { return item.ToString().Equals("Small Warrior Water"); });
            Assert.Contains(search, (item) => { return item.ToString().Equals("Medium Warrior Water"); });
            Assert.Contains(search, (item) => { return item.ToString().Equals("Large Warrior Water"); });
        }

        [Fact]
        public void ShouldCheckMAxNullPrice()
        {
            IEnumerable<IOrderItem> temp = Menu.Search("");
            IEnumerable<IOrderItem> search = Menu.Calories(temp, 5, null);
            Assert.Contains(search, (item) => { return item is BriarheartBurger; });
            Assert.Contains(search, (item) => { return item is PhillyPoacher; });
            Assert.Contains(search, (item) => { return item is ThugsTBone; });
            Assert.Contains(search, (item) => { return item is ThalmorTriple; });
            Assert.Contains(search, (item) => { return item is SmokehouseSkeleton; });
        }

        [Theory]
        [InlineData(0, 0.50)]
        public void ShouldBeCorrectResultsPrice(double? min, double? max)
        {
           
            IEnumerable<IOrderItem> temp = Menu.Search("");
            IEnumerable<IOrderItem> search = Menu.Price(temp, min, max);

            Assert.Contains(search, (item) => { return item.ToString().Equals("Small Dragonborn Waffle Fries"); });

            Assert.Contains(search, (item) => { return item.ToString().Equals("Small Warrior Water"); });
            Assert.Contains(search, (item) => { return item.ToString().Equals("Medium Warrior Water"); });
            Assert.Contains(search, (item) => { return item.ToString().Equals("Large Warrior Water"); });

        }

        [Fact]
        public void ShouldReturnCorrectType()
        {
            IEnumerable<IOrderItem> temp = Menu.Search("");
            string[] t = new string[3];
            t[0] = "Entrees";
            IEnumerable<IOrderItem> temp2 = Menu.FilterByType(t, temp);
            Assert.Contains(temp2, (item) => { return item is BriarheartBurger; });

        }

        [Fact]
        public void ShouldReturnCorrectResultTypesForDrinks()
        {
            IEnumerable<IOrderItem> temp = Menu.Search("");
            string[] t = new string[3];
            t[0] = "Drinks";
            IEnumerable<IOrderItem> temp2 = Menu.FilterByType(t, temp);

            Assert.Contains(temp2, (item) => { return item.ToString().Equals("Small Warrior Water"); });
            Assert.Contains(temp2, (item) => { return item.ToString().Equals("Medium Warrior Water"); });
            Assert.Contains(temp2, (item) => { return item.ToString().Equals("Large Warrior Water"); });
        }

        [Fact]
        public void ShouldReturnCorrectResultTypesForSides()
        {
            IEnumerable<IOrderItem> temp = Menu.Search("");
            string[] t = new string[3];
            t[0] = "Sides";
            IEnumerable<IOrderItem> temp2 = Menu.FilterByType(t, temp);

            Assert.Contains(temp2, (item) => { return item.ToString().Equals("Small Dragonborn Waffle Fries"); });
            Assert.Contains(temp2, (item) => { return item.ToString().Equals("Medium Dragonborn Waffle Fries"); });
            Assert.Contains(temp2, (item) => { return item.ToString().Equals("Large Dragonborn Waffle Fries"); });
        }
    }


}
