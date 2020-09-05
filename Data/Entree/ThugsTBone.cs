/*
 * Author: Jonathan Welch
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent the Thugs T-Bone
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThugsTBone
    {
        /// <summary>
        /// private backing variables
        /// </summary>
        private double price = 0;
        private uint calories = 0;
        private List<string> instructions;
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>The price</returns>
        public double Price
        {
            get { return price=6.44; }
        }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>The calories</returns>
        public uint Calories
        {
            get { return calories=982; }
        }
        /// <summary>
        /// Getter  and setter for backing var
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
            return "Thugs T-Bone";
        }
    }
}
