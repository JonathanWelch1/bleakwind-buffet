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
        /// <returns>A size</returns>
        public Size Size
        { get { return size; } set { size = value; } }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>A price</returns>
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
        /// <returns>The calories</returns>
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
        /// <retunrs>A list of strings</retunrs>
        public List<string> SpecialInstructions
        {
            get
            {
                instructions = new List<string>();
                return instructions;
            }
        }
        /// <summary>
        /// A override for the tostring method
        /// </summary>
        /// <returns>A string</returns>
        public override string ToString()
        {
            return size.ToString() + " Fried Miraak";
        }
    }
}
