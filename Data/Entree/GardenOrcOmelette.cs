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
        /// <summary>
        /// private backing variables
        /// </summary>
        private double price = 0;
        private uint calories = 0;
        private List<string> instructions;
        private bool broccoli = true;
        private bool mushrooms = true;
        private bool tomato = true;
        private bool cheddar = true;


        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>A bool for broccoli</returns>
        public bool Broccoli
        {
            get { return broccoli; }
            set { broccoli = value; }
        }

        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>A bool for mushrooms</returns>
        public bool Mushrooms
        {
            get { return mushrooms; }
            set { mushrooms = value; }
        }

        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>A bool for tomatos</returns>
        public bool Tomato
        { get { return tomato; }
          set { tomato = value; } 
        }
        
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>A bool for cheddar</returns>
        public bool Cheddar
        {
            get { return cheddar; }
            set { cheddar = value; }
        }

        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>A Price</returns>
        public double Price
        {
            get { return price = 4.57; }
        }

        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>The calories</returns>
        public uint Calories
        {
            get { return calories = 404; }
        }

        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns> A list of strings</returns>
        public List<string> SpecialInstructions
        {
            get
            {
                instructions = new List<string>();
                if (!broccoli)
                {
                    instructions.Add("Hold broccoli");
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
        /// <summary>
        /// A override for the tostring method
        /// </summary>
        /// <returns>A string</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
