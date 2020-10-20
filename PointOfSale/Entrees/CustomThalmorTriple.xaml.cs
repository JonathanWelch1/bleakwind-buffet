using BleakwindBuffet.Data.Entrees;
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
using BleakwindBuffet.Data;
using PointOfSale.ComboFolder;

namespace PointOfSale.Entrees
{
    /// <summary>
    /// Interaction logic for CustomThalmorTriple.xaml
    /// </summary>
    public partial class CustomThalmorTriple : UserControl
    {
        private MainWindow mw;
        private ThalmorTriple TT;
        private Order _l;
        private ComboClass CC;
        /// <summary>
        /// Constructor for class
        /// </summary>
        /// <param name="sw">Main window being passed through</param>
        public CustomThalmorTriple(MainWindow sw, ComboClass cc,ThalmorTriple tt, Order l)
        {
            InitializeComponent();
            TT = tt;
            _l = l;
            DataContext = TT;
            mw = sw;
            CC = cc;
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
                var itemRemoved = TT;
                o.Remove(itemRemoved);
            }
        }
        /// <summary>
        /// Switches Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DoneClick(object sender, RoutedEventArgs e)
        {
            mw.swapScreen(new ButtonControl(mw));
        }

        void BackComboClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order o)
            {
                mw.swapScreen(new ComboMainScreen(mw, CC, o));
            }
        }
    }
}
