/*
 * Author: Jonathan Welch
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to represent the Garden Orc Omelette
 */
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette : Entree, INotifyPropertyChanged
    {
        new public event PropertyChangedEventHandler PropertyChanged;

        public string Name
        { get { return this.ToString(); } }
        /// <summary>
        /// private backing variables
        /// </summary>
        private List<string> instructions;
        private bool broccoli = true;
        private bool mushrooms = true;
        private bool tomato = true;
        private bool cheddar = true;


        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>A bool for broccoli</returns>
        public bool Broccoli
        {
            get { return broccoli; }
            set { if (broccoli != value) { broccoli = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Broccoli")); OnPropertyChange("SpecialInstructions"); }; }
        }

        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>A bool for mushrooms</returns>
        public bool Mushrooms
        {
            get { return mushrooms; }
            set { if (mushrooms != value) { mushrooms = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mushrooms")); OnPropertyChange("SpecialInstructions"); }; }
        }

        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>A bool for tomatos</returns>
        public bool Tomato
        { get { return tomato; }
          set { if (tomato != value) { tomato =value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato")); OnPropertyChange("SpecialInstructions"); }; } 
        }
        
        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>A bool for cheddar</returns>
        public bool Cheddar
        {
            get { return cheddar; }
            set { if (cheddar != value) { cheddar = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheddar")); OnPropertyChange("SpecialInstructions"); }; }
        }

        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>A Price</returns>
        public override double Price
        {
            get { return 4.57; }
        }

        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns>The calories</returns>
        public override uint Calories
        {
            get { return  404; }
        }

        /// <summary>
        /// Getter  and setter for backing var
        /// </summary>
        /// <returns> A list of strings</returns>
        public override List<string> SpecialInstructions
        {
            get
            {
                instructions = new List<string>();
                if (!broccoli)
                {
                    instructions.Add("Hold broccoli");
                }
                if (!mushrooms)
                {
                    instructions.Add("Hold mushrooms");
                }
                if (!tomato)
                {
                    instructions.Add("Hold tomato");
                }
                if (!cheddar)
                {
                    instructions.Add("Hold cheddar");
                }
                return instructions;
            }
        }
        /// <summary>
        /// A override for the tostring method
        /// </summary>
        /// <returns>A string</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }

        public override string Description
        { get { return "Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese."; } }
    }
}
