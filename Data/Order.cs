using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    public class Order : ICollection<IOrderItem> , INotifyPropertyChanged, INotifyCollectionChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChange(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public event NotifyCollectionChangedEventHandler CollectionChanged;

        public List<IOrderItem> order = new List<IOrderItem>();

        public Order()
        {
            Number = nextOrderNumber;
            nextOrderNumber++;
        }

        public static int nextOrderNumber = 1;

        public int Number { get; set; }

        private double salesTaxRate = .12;

        public double SalesTaxRate
        {
            get { return salesTaxRate; }
            set
            {
                if (salesTaxRate != value)
                {
                    salesTaxRate = value;
                    OnPropertyChange("SalesTaxRate");
                }
            }
        }


        public double Subtotal
        {
            get
            {
                double sTotal = 0;
                foreach(IOrderItem i in order)
                {
                    sTotal += i.Price;
                }
                return sTotal;
            }
        }

       public double Tax
        {
            get
            {
                double tax;
                tax = Subtotal + salesTaxRate;
                return tax;
            }
            
        }

        public double Total
        {
            get
            {
                double total;
                total = Subtotal + Tax;
                return total;
            }
        }

        public uint Calories
        {
            get
            {
                uint totalCalories = 0;
                foreach(IOrderItem item in order)
                {
                    totalCalories += item.Calories;
                }
                return totalCalories;
            }
        }

        public void Add(IOrderItem item)
        {
            order.Add(item);
            item.PropertyChanged += CollectionItemChangedListener;
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
            OnPropertyChange("Subtotal");
            OnPropertyChange("Tax");
            OnPropertyChange("Total");
            OnPropertyChange("Calories");

        }

        public bool Remove(IOrderItem item)
        {
           
            int index = order.FindIndex(i=>i == item);
            var remove = order.Remove(item);
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item, index));
            OnPropertyChange("Subtotal");
            OnPropertyChange("Tax");
            OnPropertyChange("Total");
            OnPropertyChange("Calories");
            return remove;
        }

        void CollectionItemChangedListener(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "Price")
            {
                OnPropertyChange("Subtotal");
                OnPropertyChange("Tax");
                OnPropertyChange("Total");
            }
            if(e.PropertyName == "Calories")
            {
                OnPropertyChange("Calories");
            }
        }
        public int Count => order.Count;

        public void Clear()
        {
            foreach(IOrderItem item in order)
            {
                item.PropertyChanged -= CollectionItemChangedListener;
            }
            order.Clear();
        }

        public bool Contains(IOrderItem item)
        {
            return order.Contains(item);
        }

        public void CopyTo(IOrderItem[] array, int arrayIndex)
        {
            order.CopyTo(array, arrayIndex);
        }

        public IEnumerator<IOrderItem> GetEnumerator()
        {
            return order.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return order.GetEnumerator();
        }

        public bool IsReadOnly => false;
    }

    

}
