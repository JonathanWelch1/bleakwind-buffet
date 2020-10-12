using System;
using System.Collections.Generic;
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
using BleakwindBuffet.Data.Drinks;
using Size = BleakwindBuffet.Data.Enums.Size;
using BleakwindBuffet.Data;

namespace PointOfSale.Drinks
{
    /// <summary>
    /// Interaction logic for CustomMarkathMilk.xaml
    /// </summary>
    public partial class CustomMarkathMilk : UserControl
    {
        private MainWindow mw;
        private MarkarthMilk MM;
        private Order _l;
        /// <summary>
        /// Constructor for class
        /// </summary>
        /// <param name="sw">Main window being passed through</param>
        public CustomMarkathMilk(MainWindow sw, MarkarthMilk mm, Order l)
        {
            InitializeComponent();
            MM = mm;
            _l = l;
            DataContext = MM;
            mw = sw;
        }
        /// <summary>
        /// Switches Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            mw.swapScreen(new ButtonControl(mw));
            DataContext = _l;
            if (DataContext is Order o)
            {
                var itemRemoved = MM;
                o.Remove(itemRemoved);
            }
        }
        /// <summary>
        /// Switches Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Done_Click(object sender, RoutedEventArgs e)
        {
            mw.swapScreen(new ButtonControl(mw));
        }
        void checkboxChecked(object sender, RoutedEventArgs e)
        {
            Size s;

            if (sender is CheckBox cb)
            {
                switch (cb.Name)
                {
                    case "Small":
                        s = Size.Small;
                        Small.IsChecked = true;
                        Medium.IsChecked = false;
                        Large.IsChecked = false;
                        break;
                    case "Medium":
                        s = Size.Medium;
                        Small.IsChecked = false;
                        Medium.IsChecked = true;
                        Large.IsChecked = false;
                        break;
                    case "Large":
                        s = Size.Large;
                        Small.IsChecked = false;
                        Medium.IsChecked = false;
                        Large.IsChecked = true;
                        break;
                    default:
                        throw new NotImplementedException();
                }
                MM.Size = s;
                DataContext = MM;
            }
        }
    }
}
