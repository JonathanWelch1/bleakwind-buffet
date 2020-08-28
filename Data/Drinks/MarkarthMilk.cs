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
        private Size currentSize = Size.Small;
        private bool ice = false;
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
                    price = 1.05;
                }
                else if (currentSize == Size.Medium)
                {
                    price = 1.11;
                }
                else
                {
                    price = 1.22;
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
                    calories = 56;
                }
                else if (currentSize == Size.Medium)
                {
                    calories = 72;
                }
                else
                {
                    calories = 93;
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
        //dis needs fixin
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
