/*
 * Author: Jonathan Welch
 * Class name: DoubleDraugr.cs
 * Purpose: Class used to represent the Double Draugr
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class DoubleDraugr
    {
        private double price = 0;
        private uint calories = 0;
        private List<string> instructions;
        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;
        private bool tomato = true;
        private bool lettuce = true;
        private bool mayo = true;


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

        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value; }
        }

        public bool Mayo
        {
            get { return mayo; }
            set { mayo = value; }
        }

        public bool Lettuce
        {
            get { return lettuce; }
            set { lettuce = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = 7.32; }
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
                if (!tomato)
                {
                    instructions.Add("Hold tomato");
                }
                if (!lettuce)
                {
                    instructions.Add("Hold lettuce");
                }
                if (!mayo)
                {
                    instructions.Add("Hold mayo");
                }
                return instructions;
            }
        }

        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
