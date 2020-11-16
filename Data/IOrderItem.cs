using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    public interface IOrderItem : INotifyPropertyChanged
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

        /// <summary>
        /// Getter method that would get the description of a item in the menu
        /// </summary>
        string Description
        {
            get;
        }

    }
}
