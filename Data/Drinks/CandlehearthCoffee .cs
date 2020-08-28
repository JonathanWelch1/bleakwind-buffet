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
        private Size currentSize = Size.Small;
        private bool ice = false;
        private bool roomforcream = false;
        private bool decaf = false;

        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        public double Price
        {
            get { return price; }
            set
            {
                if (currentSize == Size.Small)
                {
                    price = 0.85;
                }
                else if (currentSize == Size.Medium)
                {
                    price = 1.25;
                }
                else
                {
                    price = 1.75;
                }
            }
        }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        public uint Calories
        {
            get { return calories; }
            set
            {
                if (currentSize == Size.Small)
                {
                    calories = 7;
                }
                else if (currentSize == Size.Medium)
                {
                    calories = 10;
                }
                else
                {
                    calories = 20;
                }
            }
        }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        public bool RoomForCream
        {
            get { return roomforcream; }
            set { roomforcream = value; }
        }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        public bool Decaf
        {
            get { return decaf; }
            set { decaf = value; }
        }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                instructions = new List<string>();
                if (ice)
                {
                    instructions.Add("Add Ice");
                }
                if(roomforcream)
                {
                    instructions.Add("Add cream");
                }
              /*  if(Decaf)
                {
                    //do stuff
                } */
                return instructions;
            }
        }
        //dis needs fixin
        public override string ToString()
        {
            return base.ToString();
        }
    }

}
