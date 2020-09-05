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
        /// <returns>different Size</returns>
        public Size Size
        { get { return size; } set { size = value; } }


        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>Price for different Size</returns>
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
        /// <return>Returns the Calories</return>
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
        /// <returns>Returns ice</returns>
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>Returns lemon</returns>
        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value; }
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

        /// <summary>
        /// Overrides the string
        /// </summary>
        /// <returns>returns a string</returns>
        public override string ToString()
        {
            return size.ToString() + " Warrior Water";
        }
    }
}
