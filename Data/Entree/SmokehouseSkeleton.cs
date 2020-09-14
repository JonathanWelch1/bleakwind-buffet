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
    public class SmokehouseSkeleton : Entree
    {
        /// <summary>
        /// private backing variables
        /// </summary>
        private List<string> instructions;
        private bool sausageLink = true;
        private bool egg = true;
        private bool hashBrowns = true;
        private bool pancake = true;

        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>A bool for sausage links</returns>
        public bool SausageLink
        {
            get { return sausageLink; }
            set { sausageLink = value; }
        }

        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>A bool for egg</returns>
        public bool Egg
        {
            get { return egg; }
            set { egg = value; }
        }

        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>A bool for Hasbrowns</returns>
        public bool HashBrowns
        { get { return hashBrowns; } set { hashBrowns = value; } }

        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>A bool for pancake</returns>
        public bool Pancake
        {
            get { return pancake; }
            set { pancake = value; }
        }

        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>A price</returns>
        public override double Price
        {
            get { return 5.32; }

        }

        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>The calories</returns>
        public override uint Calories
        {
            get { return 602; }
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
        /// <summary>
        /// A override for the tostring method
        /// </summary>
        /// <returns>A string</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
