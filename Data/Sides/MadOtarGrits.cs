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
                    return price = 1.22;
                }
                else if (size == Size.Medium)
                {
                    return price = 1.58;
                }
                else
                {
                    return price = 1.93;
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
                    return calories = 105;
                }
                else if (size == Size.Medium)
                {
                    return calories = 142;
                }
                else
                {
                    return calories = 179;
                }
            }
        }
        /// <summary>
        /// Returns an empty list
        /// </summary>
        /// <returns>A list of strings</returns>
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
            return size.ToString() + " Mad Otar Grits";
        }
    }
}
