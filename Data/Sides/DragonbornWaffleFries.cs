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
        private Size currentSize = Size.Small;

        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        public double Price
        {
            get { return price; }
            set
            {
                if (currentSize == Size.Small)
                {
                    price = 0.42;
                }
                else if (currentSize == Size.Medium)
                {
                    price = 0.76;
                }
                else
                {
                    price = 0.96;
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
                if (currentSize == Size.Small)
                {
                    calories = 77;
                }
                else if (currentSize == Size.Medium)
                {
                    calories = 89;
                }
                else
                {
                    calories = 100;
                }
            }
        }
        //Fix dis
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
