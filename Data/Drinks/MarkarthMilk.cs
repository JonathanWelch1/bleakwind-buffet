using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class MarkarthMilk : Drink
    {
        /// <summary>
        /// private backing variables
        /// </summary>
        private List<string> instructions;
        private Size size = Size.Small;
        private bool ice = false;

        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>Price for different Size</returns>
        public override double Price
        {
            get {
                if (Size == Size.Small)
                {
                   return 1.05;
                }
                else if (Size == Size.Medium)
                {
                   return  1.11;
                }
                else
                {
                   return 1.22;
                }
            }
        }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <return>Returns the Calories</return>
        public override uint Calories
        {
            get {
                if (Size == Size.Small)
                {
                   return 56;
                }
                else if (Size == Size.Medium)
                {
                   return  72;
                }
                else
                {
                   return 93;
                }
            }
        }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>Returns Ice</returns>
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>A list of strings</returns>
        public override List<string> SpecialInstructions
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
        /// <returns>Returns a string</returns>
        public override string ToString()
        {
            return Size.ToString() + " Markarth Milk";
        }
    }
}
