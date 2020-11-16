/*
 * Author: Jonathan Welch
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to represent DragonbornWaffleFries 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public class DragonbornWaffleFries : Side
    {
        public string Name
        { get { return this.ToString(); } }
        /// <summary>
        /// private backing variables
        /// </summary>
        private List<string> instructions;

        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>The price</returns>
        public override double Price
        {
            get {
                if (Size == Size.Small)
                {
                    return 0.42;
                }
                else if (Size == Size.Medium)
                {
                    return 0.76;
                }
                else
                {
                    return 0.96;
                }
            }
        }
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>The calories</returns>
        public override uint Calories
        {
            get {
                if (Size == Size.Small)
                {
                    return  77;
                }
                else if (Size == Size.Medium)
                {
                    return 89;
                }
                else
                {
                    return  100;
                }
            }
        }
        /// <summary>
        /// Returns an empty list
        /// </summary>
        /// <returns>A list of strings</returns>
        public override List<string> SpecialInstructions
        {
            get
            {
                instructions = new List<string>();
                return instructions;
            }
        }
        /// <summary>
        /// Overrides the tostring method
        /// </summary>
        /// <returns>A string</returns>
        public override string ToString()
        {
            return Size.ToString() + " Dragonborn Waffle Fries";
        }

        public override string Description { get { return "Crispy fried potato waffle fries."; } }

    }
}
