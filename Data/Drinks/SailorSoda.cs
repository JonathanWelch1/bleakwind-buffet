using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda
    {
        /// <summary>
        /// private backing variables
        /// </summary>
        private double price;
        private uint calories;
        private List<string> instructions;
        private Size currentSize = Size.Small;
        private Sodaflavor currentFlavor = Sodaflavor.Cherry;
        private bool ice = true;


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
                    price = 1.42;
                }
                else if (currentSize == Size.Medium)
                {
                    price = 1.74;
                }
                else
                {
                    price = 2.07;
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
                    calories = 117;
                }
                else if (currentSize == Size.Medium)
                {
                    calories = 153;
                }
                else
                {
                    calories = 205;
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
                if(!ice)
                {
                    instructions.Add("Hold Ice");
                }
                return instructions;
            }        
        
        }

        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        public Size CurrentSize
        {
            get { return currentSize;}
            set { currentSize = value;}
        }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        public Sodaflavor CurrentFlavor
        {
            get { return currentFlavor;}
            set { currentFlavor = value;}
        }
        // look at dis guy
        public override string ToString()
        {
            return "[Size] [Flavor] Sailor Soda";
        }
    }
}
