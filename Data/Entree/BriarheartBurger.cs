﻿/*
 * Author: Jonathan Welch
 * Class name: Briarheart Burger.cs
 * Purpose: Class used to represent the briarheart burger
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class BriarheartBurger : Entree 
    {
        /// <summary>
        /// private backing variables
        /// </summary>
        private List<string> instructions;
        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;

        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>bool Cheese</returns>
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>A bool pickle</returns>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>Mustard</returns>
        public bool Mustard
        { get { return mustard; } set { mustard = value; } }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>A bool bun</returns>
        public bool Bun
        {
            get { return bun; }
            set { bun = value; }
        }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>A bool for ketchup</returns>
        public bool Ketchup
        {
            get { return ketchup; }
            set { ketchup = value; }
        }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>The price</returns>
        public override double Price
        {
            get { return  6.32; }
        }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <return>The calories</return>
        public override uint Calories
        {
            get { return 743; }
        }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>A list of string</returns>
        public override List<string> SpecialInstructions
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

        /// <summary>
        /// A override for strings
        /// </summary>
        /// <returns>A string is reutrned</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
