/*
 * Author: Jonathan Welch
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent FriedMiraak 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public class FriedMiraak : Side, INotifyPropertyChanged
    {
        public string Name
        { get { return this.ToString(); } }
        /// <summary>
        /// private backing variables
        /// </summary>
        private Size size = Size.Small;
        private List<string> instructions;
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>A price</returns>
        public override double Price
        {
            get { 
                if (Size == Size.Small)
                {
                    return  1.78;
                }
                else if (Size == Size.Medium)
                {
                    return  2.01;
                }
                else
                {
                    return  2.88;
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
                    return  151;
                }
                else if (Size == Size.Medium)
                {
                    return  236;
                }
                else
                {
                    return 306;
                }
            }
        }
        /// <summary>
        /// Returns an empty list
        /// </summary>
        /// <retunrs>A list of strings</retunrs>
        public override List<string> SpecialInstructions
        {
            get
            {
                instructions = new List<string>();
                return instructions;
            }
        }
        /// <summary>
        /// A override for the tostring method
        /// </summary>
        /// <returns>A string</returns>
        public override string ToString()
        {
            return Size.ToString() + " Fried Miraak";
        }

        public override string Description { get { return "Perfectly prepared hash brown pancakes."; } }
    }
}
