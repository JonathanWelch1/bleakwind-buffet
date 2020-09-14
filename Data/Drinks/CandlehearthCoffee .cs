using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee : Drink
    {

        /// <summary>
        /// private backing variables
        /// </summary>
        private List<string> instructions;
        private bool ice = false;
        private bool roomForCream = false;
        private bool decaf = false;


        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>Price for different Size</returns>
        public override double Price
        {
            get { 
            
            
                if (Size == Size.Small)
                {
                    return 0.75;
                }
                else if (Size == Size.Medium)
                {
                    return 1.25;
                }
                else
                {
                   return 1.75;
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
                    return 7;
                }
                else if (Size == Size.Medium)
                {
                    return  10;
                }
                else
                {
                    return  20;
                }
            }
        }

        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>returns Ice</returns>
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>Returns RoomForCream</returns>
        public bool RoomForCream
        {
            get { return roomForCream; }
            set { roomForCream = value; }
        }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>Returns Decaf</returns>
        public bool Decaf
        {
            get { return decaf; }
            set { decaf = value; }
        }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>a list of strings</returns>
        public override List<string> SpecialInstructions
        {
            get
            {
                instructions = new List<string>();
                if (ice)
                {
                    instructions.Add("Add Ice");
                }
                if(roomForCream)
                {
                    instructions.Add("Add Cream");
                }
                return instructions;
            }
        }

        /// <summary>
        /// Overridest the string
        /// </summary>
        /// <returns>Returns with decaf</returns>
        /// <returns>Returns without decaf</returns>
        public override string ToString()
        {

            if (decaf)
            {
                return Size.ToString() + " Decaf Candlehearth Coffee";
            }
            else
            {
                return Size.ToString() + " Candlehearth Coffee";
            } 
        }
    }

}
