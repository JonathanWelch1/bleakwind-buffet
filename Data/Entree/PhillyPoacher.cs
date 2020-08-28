/*
 * Author: Jonathan Welch
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent the Philly Poacher
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher
    {
        /// <summary>
        /// private backing variables
        /// </summary>
        private double price = 0;
        private uint calories = 0;
        private List<string> instructions;
        private bool sirloin = true;
        private bool onion = true;
        private bool roll = true;

        public bool Sirloin
        {
            get { return sirloin; }
            set { sirloin = value; }
        }

        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        public bool Onion
        {
            get { return onion; }
            set { onion = value; }
        }

        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        public bool Roll
        { get { return roll; } set { roll = value; } }

        public double Price
        {
            get { return price; }
            set { price = 7.23; }
        }

        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        public uint Calories
        {
            get { return calories; }
            set { calories = 784; }
        }

        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                instructions = new List<string>();
                if (!sirloin)
                {
                    instructions.Add("Hold sirloin");
                }
                if (!onion)
                {
                    instructions.Add("Hold onion");
                }
                if (!roll)
                {
                    instructions.Add("Hold roll");
                }
                return instructions;
            }
        }
        //fix dis
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
