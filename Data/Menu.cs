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
            List<IOrderItem> fullMenu = new List<IOrderItem>();
            fullMenu.AddRange(Sides());
            fullMenu.AddRange(Entrees());
            fullMenu.AddRange(Drinks());
            return fullMenu;
        }
    }
}
