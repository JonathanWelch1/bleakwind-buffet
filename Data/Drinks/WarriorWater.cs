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
        private Size currentSize = Size.Small;
        private bool ice = true;
        private bool lemon = false;
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
                    price = 0;
                }
                else if (currentSize == Size.Medium)
                {
                    price = 0;
                }
                else
                {
                    price = 0;
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
                    calories = 0;
                }
                else if (currentSize == Size.Medium)
                {
                    calories = 0;
                }
                else
                {
                    calories = 0;
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
                /*  if(Decaf)
                  {
                      //do stuff
                  } */
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
