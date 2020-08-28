/*
 * Author: Jonathan Welch
 * Class name: VokunSalad.cs
 * Purpose: Class used to represent VokunSalad 
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;


namespace BleakwindBuffet.Data.Sides
{
    public class VokunSalad
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
                    price = .93;
                }
                else if (currentSize == Size.Medium)
                {
                    price = 1.28;
                }
                else
                {
                    price = 1.82;
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
                    calories = 41;
                }
                else if (currentSize == Size.Medium)
                {
                    calories = 52;
                }
                else
                {
                    calories = 73;
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
