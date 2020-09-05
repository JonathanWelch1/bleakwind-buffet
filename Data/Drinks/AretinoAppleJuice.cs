﻿using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class AretinoAppleJuice
    {
        /// <summary>
        /// private backing variables
        /// </summary>
        private double price;
        private uint calories;
        private List<string> instructions;
        private Size size = Size.Small;
        private bool ice = false;

        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>Price for different Size</returns>
        public double Price
        {
            get { 
                if (size == Size.Small)
                {
                   return price = 0.62;
                }
                else if (size == Size.Medium)
                {
                   return price = 0.87;
                }
                else
                {
                   return price = 1.01;
                }
            }
        } 


        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>The size</returns>
        public Size Size
        { get { return size; } set { size = value; } }


        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <return>Returns the Calories</return>
        public uint Calories
        {
            get { 
                if (size == Size.Small)
                {
                    return calories = 44;
                }
                else if (size == Size.Medium)
                {
                   return calories = 88;
                }
                else
                {
                   return calories = 132;
                }
            }
        }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>The Ice</returns>
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
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
                if (ice)
                {
                    instructions.Add("Add Ice");
                }
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the string
        /// </summary>
        /// <returns>returns a string</returns>
        public override string ToString()
        {
            return size.ToString() + " Aretino Apple Juice";
        }
    }
}
