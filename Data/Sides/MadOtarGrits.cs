/*
 * Author: Jonathan Welch
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to represent MadOtarGrits 
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public class MadOtarGrits : Side
    {
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
                    return 1.22;
                }
                else if (Size == Size.Medium)
                {
                    return 1.58;
                }
                else
                {
                    return 1.93;
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
                    return 105;
                }
                else if (Size == Size.Medium)
                {
                    return  142;
                }
                else
                {
                    return 179;
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
        /// A override for the tostring method
        /// </summary>
        /// <returns>A string</returns>
        public override string ToString()
        {
            return Size.ToString() + " Mad Otar Grits";
        }
    }
}
