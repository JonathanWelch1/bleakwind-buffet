/*
 * Author: Jonathan Welch
 * Class name: Entree.cs
 * Purpose: Class used to represent the Entree base class 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public abstract class Entree : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChange(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        /// <summary>
        /// The price of the drink
        /// </summary>
        /// <value>
        /// In us dollars
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special Instructions to prepare the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

    }
}
