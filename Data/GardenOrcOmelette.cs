/*
 * Author: Jonathan Welch
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to represent the Garden Orc Omelette
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette
    {
        private double price = 0;
        private uint calories = 0;
        private List<string> instructions;
        private bool broccoli = true;
        private bool mushrooms = true;
        private bool tomato = true;
        private bool cheddar = true;

        public bool Broccoli
        {
            get { return broccoli; }
            set { broccoli = value; }
        }

        public bool Mushrooms
        {
            get { return mushrooms; }
            set { mushrooms = value; }
        }

        public bool Tomato
        { get { return tomato; } set { tomato = value; } }

        public bool Cheddar
        {
            get { return cheddar; }
            set { cheddar = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = 4.57; }
        }

        public uint Calories
        {
            get { return calories; }
            set { calories = 404; }
        }

        public List<string> SpecialInstructions
        {
            get
            {
                instructions = new List<string>();
                if (!broccoli)
                {
                    instructions.Add("Hold mushrooms");
                }
                if (!mushrooms)
                {
                    instructions.Add("Hold mushrooms");
                }
                if (!tomato)
                {
                    instructions.Add("Hold tomato");
                }
                if (!cheddar)
                {
                    instructions.Add("Hold cheddar");
                }
                return instructions;
            }
        }
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
