/*******************************************************
 * Author: Jonathan Welch
 * 
 * 
 ******************************************************/
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using System;
using System.Collections.Generic;
using BleakwindBuffet.Data.Enums;
using System.Linq;
using System.Security.Claims;

namespace BleakwindBuffet.Data
{
    public static class Menu
    {
        /// <summary>
        /// This method creates a list of all Entrees
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entree = new List<IOrderItem>();
            entree.Add(new BriarheartBurger());
            entree.Add(new DoubleDraugr());
            entree.Add(new GardenOrcOmelette());
            entree.Add(new PhillyPoacher());
            entree.Add(new SmokehouseSkeleton());
            entree.Add(new ThalmorTriple());
            entree.Add(new ThugsTBone());
            return entree;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();
            foreach(Size s in Enum.GetValues(typeof(Size)))
            {
                sides.Add(new DragonbornWaffleFries() { Size = s });
                sides.Add(new FriedMiraak() { Size = s });
                sides.Add(new MadOtarGrits() { Size = s });
                sides.Add(new VokunSalad() { Size = s });
            }
            return sides;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();
            foreach(Size s in Enum.GetValues(typeof(Size)))
            {
                drinks.Add(new AretinoAppleJuice() { Size = s });
                drinks.Add(new CandlehearthCoffee() { Size = s });
                drinks.Add(new MarkarthMilk() { Size = s });
                foreach(SodaFlavor f in Enum.GetValues(typeof(SodaFlavor)))
                {
                    drinks.Add(new SailorSoda() { Size = s, Flavor = f });
                }
                
                drinks.Add(new WarriorWater() { Size = s });
            }
            return drinks;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> fullmenu = new List<IOrderItem>();
            fullmenu.AddRange(Sides());
            fullmenu.AddRange(Entrees());
            fullmenu.AddRange(Drinks());
            return fullmenu;
        }

        public static IEnumerable<IOrderItem> All { get { return FullMenu(); } }

        /// <summary>
        /// Searches algorithm
        /// </summary>
        /// <param name="term">Name of the item being passed throughg</param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Search(string term)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            if (term == null)
            {
                return All;
            }

            foreach(IOrderItem item in All)
            {
                if (item.ToString() != null && item.ToString().ToLower().Contains(term.ToLower()))
                {
                    results.Add(item);
                }
            }
            return results;
        }
        /// <summary>
        /// A filter for the user to input certain calories
        /// </summary>
        /// <param name="item">Item being passed through</param>
        /// <param name="min">Minimal Calories being passed in</param>
        /// <param name="max">Maximal Calories being passed in</param>
        /// <returns>a list of items within the specified range</returns>
        public static IEnumerable<IOrderItem> Calories(IEnumerable<IOrderItem> item, int? min, int? max)
        {
            var results = new List<IOrderItem>();
            if(min == null && max == null)
            {
                return item;
            }

            if(min == null)
            {
                foreach(IOrderItem i in item)
                {
                    if (i.Calories <= max) results.Add(i);
                }
                return results;
            }

            if(max == null)
            {
                foreach(IOrderItem i in item)
                {
                    if (i.Calories >= min) results.Add(i);
                }
                return results;
            }

            foreach(IOrderItem i in item)
            {
                if(i.Calories >= min && i.Calories <= max)
                {
                    results.Add(i);
                }
            }
            return results;
        }

        /// <summary>
        /// A
        /// </summary>
        /// <param name="item"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Price(IEnumerable<IOrderItem> item, double? min, double? max)
        {
            var results = new List<IOrderItem>();
            if (min == null && max == null)
            {
                return item;
            }

            if (min == null)
            {
                foreach (IOrderItem i in item)
                {
                    if (i.Price <= max) results.Add(i);
                }
                return results;
            }

            if (max == null)
            {
                foreach (IOrderItem i in item)
                {
                    if (i.Price >= min) results.Add(i);
                }
                return results;
            }

            foreach (IOrderItem i in item)
            {
                if (i.Price >= min && i.Price <= max)
                {
                    results.Add(i);
                }
            }
            return results;
        }
        /// <summary>
        /// Filters by Type
        /// </summary>
        /// <param name="type">Type being passed througgh</param>
        /// <param name="Item">Menu Item</param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByType(IEnumerable<string> MenuType, IEnumerable<IOrderItem> Menu)
        {
            if(MenuType == null || MenuType.Count() == 0)
            {
                return Menu;
            }

            List<IOrderItem> results = new List<IOrderItem>();

            if(MenuType.Contains("Entrees"))
            {
                foreach(IOrderItem item in Menu)
                {
                    if(item is Entree)results.Add(item);
                }
            }
            if (MenuType.Contains("Drinks"))
            {
                foreach (IOrderItem item in Menu)
                {
                    if (item is Drink) results.Add(item);
                }
            }
            if (MenuType.Contains("Sides"))
            {
                foreach (IOrderItem item in Menu)
                {
                    if (item is Side) results.Add(item);
                }
            }
            return results;
        }
    }
}
