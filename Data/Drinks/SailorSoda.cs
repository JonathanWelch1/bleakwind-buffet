﻿using BleakwindBuffet.Data.Enums;
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
        private Size size = Size.Small;
        private Sodaflavor flavor = Sodaflavor.Cherry;
        private bool ice = true;

        public Size Size
        { get { return size; } set { size = value; } }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        public double Price
        {
            get { 
                if (size == Size.Small)
                {
                    return price = 1.42;
                }
                else if (size == Size.Medium)
                {
                    return price = 1.74;
                }
                else
                {
                   return price = 2.07;
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
                    return calories = 117;
                }
                else if (size == Size.Medium)
                {
                    return calories = 153;
                }
                else
                {
                    return calories = 205;
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
            get { return size; }
            set { size = value;}
        }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        public Sodaflavor Flavor
        {
            get { return flavor; }
            set { flavor = value;}
        }
        // look at dis guy
        public override string ToString()
        {
            return size.ToString() + " " +  flavor.ToString() + " Sailor Soda";
        }
    }
}