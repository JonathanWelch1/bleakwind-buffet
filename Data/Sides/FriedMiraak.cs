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
        private List<string> instructions;
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
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
            get { 
                if (size == Size.Small)
                {
                    return calories = 151;
                }
                else if (size == Size.Medium)
                {
                    return calories = 236;
                }
                else
                {
                    return calories = 306;
                }
            }
        }
        /// <summary>
        /// Returns an empty list
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                instructions = new List<string>();
                return instructions;
            }
        }
        public override string ToString()
        {
            return size.ToString() + " Fried Miraak";
        }
    }
}
