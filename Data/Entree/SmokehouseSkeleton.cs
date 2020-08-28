/*
 * Author: Jonathan Welch
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent the smokehouse skeleton
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton
    {
        /// <summary>
        /// private backing variables
        /// </summary>
        private double price = 0;
        private uint calories = 0;
        private List<string> instructions;
        private bool sausageLink = true;
        private bool egg = true;
        private bool hashBrowns = true;
        private bool pancake = true;

        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        public bool SausageLink
        {
            get { return sausageLink; }
            set { sausageLink = value; }
        }

        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set { egg = value; }
        }

        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        public bool Hashbrowns
        { get { return hashBrowns; } set { hashBrowns = value; } }

        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        public bool Pancake
        {
            get { return pancake; }
            set { pancake = value; }
        }

        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        public double Price
        {
            get { return price=5.32; }

        }

        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        public uint Calories
        {
            get { return calories=602; }
        }

        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                instructions = new List<string>();
                if (!pancake)
                {
                    instructions.Add("Hold pancake");
                }
                if (!sausageLink)
                {
                    instructions.Add("Hold sausagelink");
                }
                if (!egg)
                {
                    instructions.Add("Hold egg");
                }
                if (!hashBrowns)
                {
                    instructions.Add("Hold Hashbrowns");
                }
                return instructions;
            }
        }
        //fix dis
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
