/*
 * Author: Jonathan Welch
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to represent MadOtarGrits 
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public class MadOtarGrits
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
                    price = 1.22;
                }
                else if (currentSize == Size.Medium)
                {
                    price = 1.58;
                }
                else
                {
                    price = 1.93;
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
                    calories = 105;
                }
                else if (currentSize == Size.Medium)
                {
                    calories = 142;
                }
                else
                {
                    calories = 179;
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
