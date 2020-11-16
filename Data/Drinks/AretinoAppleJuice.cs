using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    public class AretinoAppleJuice : Drink
    {
        /// <summary>
        /// private backing variables
        /// </summary>
        private List<string> instructions;
        private bool ice = false;
        
        public string Name
        { get { return this.ToString(); } }
        

        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>Price for different Size</returns>
        public override double Price
        {
            get { 
                if (Size == Size.Small)
                {
                   return 0.62;
                }
                else if (Size == Size.Medium)
                {
                   return  0.87;
                }
                else
                {
                   return 1.01;
                }
                throw new NotImplementedException("Should never be reached");
            }
           
    } 
        /// <summary>
        /// Getter  and setter for backing var
        /// implementing the abstract base class
        /// </summary>
        /// <return>Returns the Calories</return>
        public override uint Calories
        {
            get { 
                if (Size == Size.Small)
                {
                    return  44;
                }
                else if (Size == Size.Medium)
                {
                   return  88;
                }
                else
                {
                   return  132;
                }
                throw new NotImplementedException("Should never be reached");
            }
        }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>The Ice</returns>
        public bool Ice
        {
            get { return ice; }
            set {
                if (ice != value)
                {
                    ice = value; 
                    OnPropertyChange("Ice");
                    OnPropertyChange("SpecialInstructions");
                }
            }
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
                if (ice)
                {
                    instructions.Add("Add Ice");
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
            return Size.ToString() + " Aretino Apple Juice";
        }

        public override string Description { get { return "Fresh squeezed apple juice."; } }
    }
}
