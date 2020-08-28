/*
 * Author: Jonathan Welch
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent FriedMiraak 
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public class FriedMiraak
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
                    return price = 1.78;
                }
                else if (size == Size.Medium)
                {
                    return price = 2.01;
                }
                else
                {
                    return price = 2.88;
                }
            }
        }

        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        public uint Calories
        {
            get { return calories; }
            set
            {
                if (size == Size.Small)
                {
                    calories = 151;
                }
                else if (size == Size.Medium)
                {
                    calories = 236;
                }
                else
                {
                    calories = 306;
                }
            }
        }
        public override string ToString()
        {
            return size.ToString() + " Fried Miraak";
        }
    }
}
