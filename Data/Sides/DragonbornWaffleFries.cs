/*
 * Author: Jonathan Welch
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to represent DragonbornWaffleFries 
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public class DragonbornWaffleFries
    {
        /// <summary>
        /// private backing variables
        /// </summary>
        private double price;
        private uint calories;
        private Size size = Size.Small;
        public Size Size
        { get { return size; } set { size = value; } }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        public double Price
        {
            get {
                if (size == Size.Small)
                {
                    return price = 0.42;
                }
                else if (size == Size.Medium)
                {
                    return price = 0.76;
                }
                else
                {
                    return price = 0.96;
                }
            }
        }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        public uint Calories
        {
            get {
                if (size == Size.Small)
                {
                    return calories = 77;
                }
                else if (size == Size.Medium)
                {
                    return calories = 89;
                }
                else
                {
                    return calories = 100;
                }
            }
        }
        public override string ToString()
        {
            return size.ToString() + " Dragonborn Waffle Fries";
        }
    }
}
