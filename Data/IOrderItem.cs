using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{
    public interface IOrderItem
    { 
        /// <summary>
        /// The price of the Drinks Entrees and Sides
        /// </summary>
        /// <value>
        /// In us dollars
        /// </value>
        double Price { get; }

        /// <summary>
        /// The calories of the  Drinks Entrees and Sides
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Special Instructions to prepare  Drinks Entrees and Sides
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
