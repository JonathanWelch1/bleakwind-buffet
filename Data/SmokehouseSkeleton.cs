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
        private double price = 0;
        private uint calories = 0;
        private List<string> instructions;
        private bool sausagelink = true;
        private bool egg = true;
        private bool hashbrowns = true;
        private bool pancake = true;

        public bool SausageLink
        {
            get { return sausagelink; }
            set { sausagelink = value; }
        }

        public bool Egg
        {
            get { return egg; }
            set { egg = value; }
        }

        public bool Hashbrowns
        { get { return hashbrowns; } set { hashbrowns = value; } }

        public bool Pancake
        {
            get { return pancake; }
            set { pancake = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = 5.32; }
        }

        public uint Calories
        {
            get { return calories; }
            set { calories = 602; }
        }

        public List<string> SpecialInstructions
        {
            get
            {
                instructions = new List<string>();
                if (!pancake)
                {
                    instructions.Add("Hold pancake");
                }
                if (!sausagelink)
                {
                    instructions.Add("Hold sausagelink");
                }
                if (!egg)
                {
                    instructions.Add("Hold egg");
                }
                if (!hashbrowns)
                {
                    instructions.Add("Hold Hashbrowns");
                }
                return instructions;
            }
        }
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
