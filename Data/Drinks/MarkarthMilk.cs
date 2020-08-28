using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class MarkarthMilk
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
        public double Price
        {
            get {
                if (size == Size.Small)
                {
                   return price = 1.05;
                }
                else if (size == Size.Medium)
                {
                   return price = 1.11;
                }
                else
                {
                   return price = 1.22;
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
                   return calories = 56;
                }
                else if (size == Size.Medium)
                {
                   return calories = 72;
                }
                else
                {
                   return calories = 93;
                }
            }
        }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }
        public Size Size
        { get { return size; } set { size = value; } }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
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
        public override string ToString()
        {
            return size.ToString() + " Markarth Milk";
        }
    }
}
