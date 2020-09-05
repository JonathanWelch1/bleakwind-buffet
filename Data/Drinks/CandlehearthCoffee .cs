using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee
    {

        /// <summary>
        /// private backing variables
        /// </summary>
        private double price;
        private uint calories;
        private List<string> instructions;
        private Size size = Size.Small;
        private bool ice = false;
        private bool roomForCream = false;
        private bool decaf = false;


        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>Price for different Size</returns>
        public double Price
        {
            get { 
            
            
                if (size == Size.Small)
                {
                    return price = 0.75;
                }
                else if (size == Size.Medium)
                {
                    return price = 1.25;
                }
                else
                {
                   return price = 1.75;
                }
            }
        }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <return>Returns the Calories</return>
        public uint Calories
        {
            get { 
                if (size == Size.Small)
                {
                    return calories = 7;
                }
                else if (size == Size.Medium)
                {
                    return calories = 10;
                }
                else
                {
                    return calories = 20;
                }
            }
        }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>Returns size</returns>
        public Size Size
        { get { return size; }set { size = value; } }

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
        public List<string> SpecialInstructions
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
                return size.ToString() + " Decaf Candlehearth Coffee";
            }
            else
            {
                return size.ToString() + " Candlehearth Coffee";
            } 
        }
    }

}
