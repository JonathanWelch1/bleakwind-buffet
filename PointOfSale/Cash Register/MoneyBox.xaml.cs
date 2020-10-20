using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale.Cash_Register
{
    /// <summary>
    /// Interaction logic for MoneyBox.xaml
    /// </summary>
    public partial class MoneyBox : UserControl
    {
        /// <summary>
        /// Constructor for money box
        /// </summary>
        public MoneyBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Dependency Property
        /// </summary>
        public static DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(int), typeof(MoneyBox), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));


        /// <summary>
        /// Getter and setter for Value
        /// </summary>
        public int Value
        {
            get { return (int)GetValue(ValueProperty); }
            set
            {
                SetValue(ValueProperty, value);
            }
        }

        /// <summary>
        /// Increments the Increment Buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Increment(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            Value++;
        }
        /// <summary>
        /// Decrements the Decremenets Buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Decrement(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            if (Value > 0)
            {
                Value--;
            }
            else { Value = 0; }
        }


    }
}
