/*
 * Author: Jonathan Welch
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent the Philly Poacher
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher : Entree
    {
        new public event PropertyChangedEventHandler PropertyChanged;

        public string Name
        { get { return this.ToString(); } }
        /// <summary>
        /// private backing variables
        /// </summary>
        private List<string> instructions;
        private bool sirloin = true;
        private bool onion = true;
        private bool roll = true;

        /// <summary>
        /// A Getter and setter for a backing variable
        /// </summary>
        /// <returns>A bool for Sirloin</returns>
        public bool Sirloin
        {
            get { return sirloin; }
            set { if (sirloin != value) { sirloin = value; OnPropertyChange("Sirloin"); OnPropertyChange("SpecialInstructions"); }; }
        }

        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>A bool for Onion</returns>
        public bool Onion
        {
            get { return onion; }
            set { if (onion != value) { onion = value; OnPropertyChange("Onion"); OnPropertyChange("SpecialInstructions"); }; }
        }

        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>A bool for roll</returns>
        public bool Roll
        { get { return roll; } set { if (roll != value) { roll = value; OnPropertyChange("Roll"); OnPropertyChange("SpecialInstructions"); }; } }

        /// <summary>
        /// The price
        /// </summary>
        /// <returns>The price</returns>
        public override double Price
        {
            get { return  7.23; }
        }

        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>Calories</returns>
        public override uint Calories
        {
            get { return  784; }
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
                if (!sirloin)
                {
                    instructions.Add("Hold sirloin");
                }
                if (!onion)
                {
                    instructions.Add("Hold onion");
                }
                if (!roll)
                {
                    instructions.Add("Hold roll");
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
            return "Philly Poacher";
        }

        public override string Description
        { get { return "Cheesesteak sandwich made from grilled sirloin, topped with onions on a fried roll."; } }
    }
}
