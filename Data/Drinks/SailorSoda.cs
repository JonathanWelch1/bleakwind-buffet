using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda : Drink
    {
        /// <summary>
        /// private backing variables
        /// </summary>
        private List<string> instructions;
        private SodaFlavor flavor = SodaFlavor.Cherry;
        private bool ice = true;




        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>Price for different Size</returns>
        public override double Price
        {
            get { 
                if (Size == Size.Small)
                {
                    return 1.42;
                }
                else if (Size == Size.Medium)
                {
                    return 1.74;
                }
                else
                {
                   return 2.07;
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
                    return 117;
                }
                else if (Size == Size.Medium)
                {
                    return 153;
                }
                else
                {
                    return 205;
                }
            }
        }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>Returns Ice</returns>
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
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
                if(!ice)
                {
                    instructions.Add("Hold Ice");
                }
                return instructions;
            }        
        
        }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>Returns the The flavor</returns>
        public SodaFlavor Flavor
        {
            get { return flavor; }
            set { flavor = value;}
        }

        /// <summary>
        /// Overrides the string
        /// </summary>
        /// <returns>Returns the stirng</returns>
        public override string ToString()
        {
            return Size.ToString() + " " +  flavor.ToString() + " Sailor Soda";
        }
    }
}
