using BleakwindBuffet.Data.Drinks;
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
using Size = BleakwindBuffet.Data.Enums.Size;
using BleakwindBuffet.Data;
using PointOfSale.ComboFolder;

namespace PointOfSale.Drinks
{
    /// <summary>
    /// Interaction logic for CustomAretinoAppleJuice.xaml
    /// </summary>
    public partial class CustomAretinoAppleJuice : UserControl
    {
        private MainWindow mw;
        private AretinoAppleJuice AA;
        private Order _l;
        private ComboClass CC;
        /// <summary>
        /// Constructor for class
        /// </summary>
        /// <param name="sw">Main window being passed through</param>
        public CustomAretinoAppleJuice(MainWindow sw, ComboClass cc,AretinoAppleJuice aj, Order l )
        {
            InitializeComponent();
            AA = aj;
            _l = l;
            CC = cc;
            DataContext = aj;
            mw = sw;
        }
        /// <summary>
        /// Switches Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DoneClick(object sender, RoutedEventArgs e)
        {
            mw.swapScreen(new ButtonControl(mw));
        }


        void checkboxChecked(object sender, RoutedEventArgs e)
        {
            Size s;

            if(sender is CheckBox cb)
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
                AA.Size = s;
                DataContext = AA;
            }
           
            
        }

        void BackComboClick(object sender, RoutedEventArgs e)
        {

                mw.swapScreen(new ComboMainScreen(mw, CC, _l));

        }

        /// <summary>
        /// Switches Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CancelClick(object sender, RoutedEventArgs e)
        {
            mw.swapScreen(new ButtonControl(mw));
            DataContext = _l;
            if (DataContext is Order o)
            {
                var itemRemoved = AA;
                o.Remove(itemRemoved);
            }
        }

    }
}
