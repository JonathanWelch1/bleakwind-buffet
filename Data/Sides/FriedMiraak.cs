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
                    price = 1.78;
                }
                else if (currentSize == Size.Medium)
                {
                    price = 2.01;
                }
                else
                {
                    price = 2.88;
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
                    calories = 151;
                }
                else if (currentSize == Size.Medium)
                {
                    calories = 236;
                }
                else
                {
                    calories = 306;
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
