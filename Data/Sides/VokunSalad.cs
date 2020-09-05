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
            get 
            {
                if (size == Size.Small)
                {
                   return  price = .93;
                }
                else if (size == Size.Medium)
                {
                    return price = 1.28;
                }
                else
                {
                    return price = 1.82;
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
                    return calories = 41;
                }
                else if (size == Size.Medium)
                {
                   return  calories = 52;
                }
                else
                {
                    return calories = 73;
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
            return size.ToString() + " Vokun Salad";
        }
    }
}
