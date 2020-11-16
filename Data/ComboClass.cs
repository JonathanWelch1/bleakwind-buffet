using BleakwindBuffet.Data.Entrees;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.Data
{
    public class ComboClass : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChange(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private Entree En;
        private Drink Dn;
        private Side Sn;
        public ComboClass(Entree e, Drink d, Side s)
        {
            En = e;
            Dn = d;
            Sn = s;
        }

        public Entree Entree
        {
            get
            {
                return En;
            }
            set
            {
                if(En!=value)
                {
                    if (En != null) Entree.PropertyChanged -= ItemPropertyChangedListener;
                    En = value;
                    En.PropertyChanged += ItemPropertyChangedListener;
                    OnPropertyChange("Entree");
                    OnPropertyChange("Price");
                    OnPropertyChange("Calories");
                    OnPropertyChange("SpecialInstructions");

                }
            }
        }
        
        public string Description
        { get { return ""; } }


        public Drink Drink
        {
            get
            {
                return Dn;
            }
            set
            {
                if (Dn != value)
                {
                    if (Dn != null) Dn.PropertyChanged -= ItemPropertyChangedListener;
                    Dn = value;
                    Dn.PropertyChanged += ItemPropertyChangedListener;
                    OnPropertyChange("Drink");
                    OnPropertyChange("Price");
                    OnPropertyChange("Calories");
                    OnPropertyChange("SpecialInstructions");

                }
            }
        }

        public Side Side
        {
            get
            {
                return Sn;
            }
            set
            {
                if (Sn != value)
                {
                    if (Sn != null) Sn.PropertyChanged -= ItemPropertyChangedListener;
                    Sn = value;
                    Sn.PropertyChanged += ItemPropertyChangedListener;
                    OnPropertyChange("Entree");
                    OnPropertyChange("Price");
                    OnPropertyChange("Calories");
                    OnPropertyChange("SpecialInstructions");

                }
            }
        }

        public double Price
        {
            get
            {
                return En.Price + Dn.Price + Sn.Price - 1;
            }
        }

        public uint Calories
        {
            get
            {
                return En.Calories + Dn.Calories + Sn.Calories;
            }
        }


        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                instructions.Add(En.ToString() + ":");
                foreach(string e in En.SpecialInstructions)
                {
                    instructions.Add(e + ", ");
                }
                instructions.Add(Dn.ToString() + ":");
                foreach(string e in Dn.SpecialInstructions)
                {
                    instructions.Add(e + ", ");
                }
                instructions.Add(Sn.ToString() + ":");
                foreach(string e in Sn.SpecialInstructions)
                {
                    instructions.Add(e + ", ");
                }

                return instructions;
            }
            set { OnPropertyChange("SpecialInstructions"); }
        }

        void ItemPropertyChangedListener(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "Price":
                    OnPropertyChange("Price");
                    break;
                case "Calories":
                    OnPropertyChange("Calories");
                    break;
                case "SpecialInstructions":
                    OnPropertyChange("SpecialInstructions");
                    break;            
            }

        }

       


        
    }
}
