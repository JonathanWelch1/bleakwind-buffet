/*
 * Author: Jonathan Welch
 * Class name: Drinks.cs
 * Purpose: Class used to represent Drink base class 
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A base class representing the common properties of drinks
    /// </summary>
    public abstract class Drink : IOrderItem, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChange(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        protected Size size = Size.Small;
        /// <summary>
        /// The size of the drink
        /// </summary>
        public virtual Size Size
        {
            get
            {
                return size;
            }
            set
            {
                if(size != value)
                {                
                    size = value;
                    OnPropertyChange("Size");
                    OnPropertyChange("Price");
                    OnPropertyChange("Calories");
                    OnPropertyChange("SpecialInstructions");
                    OnPropertyChange("Name");
                }

            }
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
