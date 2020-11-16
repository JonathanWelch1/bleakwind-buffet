using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class WarriorWater : Drink
    {

        public string Name
        { get { return this.ToString(); } }

        /// <summary>
        /// private backing variables
        /// </summary>
        private List<string> instructions;
        private bool ice = true;
        private bool lemon = false;



        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>Price for different Size</returns>
        public override double Price
        {
            get { 
                if (Size == Size.Small)
                {
                    return 0;
                }
                else if (Size == Size.Medium)
                {
                    return 0;
                }
                else
                {
                    return 0;
                }
            }
        }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <return>Returns the Calories</return>
        public override uint Calories
        {
            get {
                if (Size == Size.Small)
                {
                    return  0;
                }
                else if (Size == Size.Medium)
                {
                    return  0;
                }
                else
                {
                    return  0;
                }
            }
        }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>Returns ice</returns>
        public bool Ice
        {
            get { return ice; }
            set { if (ice != value) { ice = value; OnPropertyChange("Ice"); OnPropertyChange("SpecialInstructions"); } }
        }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>Returns lemon</returns>
        public bool Lemon
        {
            get { return lemon; }
            set { if (lemon != value) { lemon = value; OnPropertyChange("Lemon"); OnPropertyChange("SpecialInstructions"); }; }
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
                if (!ice)
                {
                    instructions.Add("Hold Ice");
                }
                if (lemon)
                {
                    instructions.Add("Add Lemon");
                }
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the string
        /// </summary>
        /// <returns>returns a string</returns>
        public override string ToString()
        {
            return Size.ToString() + " Warrior Water";
        }

        public override string Description { get { return "It’s water. Just water."; } }
    }
}
