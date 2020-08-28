using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class WarriorWater
    {
        /// <summary>
        /// private backing variables
        /// </summary>
        private double price;
        private uint calories;
        private List<string> instructions;
        private Size size = Size.Small;
        private bool ice = true;
        private bool lemon = false;
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// 
        public Size Size
        { get { return size; } set { size = value; } }
        public double Price
        {
            get { 
                if (size == Size.Small)
                {
                    return price = 0;
                }
                else if (size == Size.Medium)
                {
                    return price = 0;
                }
                else
                {
                    return price = 0;
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
                    return calories = 0;
                }
                else if (size == Size.Medium)
                {
                    return calories = 0;
                }
                else
                {
                    return calories = 0;
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
        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value; }
        }

        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                instructions = new List<string>();
                if (!ice)
                {
                    instructions.Add("Hold Ice");
                }
                if (lemon)
                {
                    instructions.Add("Add Lemon");
                }
                return instructions;
            }
        }
        //dis needs fixin
        public override string ToString()
        {
            return size.ToString() + " Warrior Water";
        }
    }
}
