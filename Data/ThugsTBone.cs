/*
 * Author: Jonathan Welch
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent the Thugs T-Bone
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThugsTBone
    {
        private double price = 0;
        private uint calories = 0;
        private List<string> instructions;

        public double Price
        {
            get { return price; }
            set { price = 6.44; }
        }

        public uint Calories
        {
            get { return calories; }
            set { calories = 982; }
        }

        public List<string> SpecialInstructions
        {
            get
            {
                instructions = new List<string>();
                return instructions;
            }
        }
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
