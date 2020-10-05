/*
 * Author: Jonathan Welch
 * Class name: ThalmorTriple.cs
 * Purpose: Class used to represent the Thalmor Triple
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThalmorTriple : Entree
    {
        new public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// private backing variables
        /// </summary>
        private List<string> instructions;
        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;
        private bool tomato = true;
        private bool lettuce = true;
        private bool mayo = true;
        private bool bacon = true;
        private bool egg = true;

        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>A bool for cheese</returns>
        public bool Cheese
        {
            get { return cheese; }
            set { if (cheese != value) { cheese = value; OnPropertyChange("Cheese"); }; }
        }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>A bool for pickle</returns>
        public bool Pickle
        {
            get { return pickle; }
            set { if (pickle != value) { pickle = value; OnPropertyChange("Pickle"); }; }
        }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>A bool for mustard</returns>
        public bool Mustard
        { get { return mustard; } set { if (mustard != value) { mustard = value; OnPropertyChange("Mustard"); }; } }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>A bool for bun</returns>
        public bool Bun
        {
            get { return bun; }
            set { if (bun != value) { bun = value; OnPropertyChange("Bun"); }; }
        }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>A bool for ketchup</returns>
        public bool Ketchup
        {
            get { return ketchup; }
            set { if (ketchup != value) { ketchup = value; OnPropertyChange("Ketchup"); }; }
        }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>A bool for tomato</returns>
        public bool Tomato
        {
            get { return tomato; }
            set { if (tomato != value) { tomato = value; OnPropertyChange("Tomato"); }; }
        }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>a bool for mayo</returns>
        public bool Mayo
        {
            get { return mayo; }
            set { if (mayo != value) { mayo = value; OnPropertyChange("Mayo"); }; }
        }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>A bool for lettuce</returns>
        public bool Lettuce
        {
            get { return lettuce; }
            set { if (lettuce != value) { lettuce = value; OnPropertyChange("Lettuce"); }; }
        }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>A bool for bacon</returns>
        public bool Bacon
        {
            get { return bacon; }
            set { if (bacon != value) { bacon = value; OnPropertyChange("Bacon"); }; }
        }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>A bool for egg</returns>
        public bool Egg
        {
            get { return egg; }
            set { if (egg != value) { egg = value; OnPropertyChange("Egg"); }; }
        }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>The price</returns>
        public override double Price
        {
            get { return 8.32; }

        }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>The calories</returns>
        public override uint Calories
        {
            get { return 943; }
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
                if (!bacon)
                {
                    instructions.Add("Hold bacon");
                }
                if (!egg)
                {
                    instructions.Add("Hold egg");
                }
                return instructions;
            }
        }
        
        /// <summary>
        /// overrides the tostring method
        /// </summary>
        /// <returns>A string</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
