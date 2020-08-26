/*
 * Author: Jonathan Welch
 * Class name: Briarheart Burger.cs
 * Purpose: Class used to represent the briarheart burger
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class BriarheartBurger
    {
        private double price = 0;
        private uint calories = 0;
        private List<string> instructions;
        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;

        public bool Cheese
        {
            get { return cheese; }
            set { pickle = value; }
        }

        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        public bool Mustard
        { get { return mustard; } set { mustard = value; } }

        public bool Bun
        {
            get { return bun; }
            set { bun = value; }
        }
        public bool Ketchup
        {
            get { return ketchup; }
            set { ketchup = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = 6.32; }
        }

        public uint Calories
        {
            get { return calories; }
            set { calories = 843; }
        }

        public List<string> SpecialInstructions
        {
            get
            {
                instructions = new List<string>();
                if (!bun)
                {
                    instructions.Add("Hold bun");
                }
                if (!ketchup)
                {
                    instructions.Add("Hold ketchup");
                }
                if (!mustard)
                {
                    instructions.Add("Hold mustard");
                }
                if (!pickle)
                {
                    instructions.Add("Hold pickle");
                }
                if (!cheese)
                {
                    instructions.Add("Hold cheese");
                }
                return instructions;
            }
        }

        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
