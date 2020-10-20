using BleakwindBuffet.Data;
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

namespace PointOfSale.ComboFolder
{
    /// <summary>
    /// Interaction logic for ComboMainScreen.xaml
    /// </summary>
    public partial class ComboMainScreen : UserControl
    {
        public MainWindow mw
        {
            get; set;
        }
        private ComboClass CC;

        /// <summary>
        /// Constructor for the class
        /// </summary>
        /// <param name="sw"></param>
        /// <param name="cc"></param>
        /// <param name="l"></param>
        public ComboMainScreen(MainWindow sw, ComboClass cc, Order l)
        {
            InitializeComponent();
            mw = sw;
            CC = cc;
            DataContext = l;
        }

        /// <summary>
        /// Entree Click Button EventHandler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void EntreeClick(Object sender, RoutedEventArgs e)
        {
            if(DataContext is Order l)
            {
                mw.swapScreen(new Entree(mw, CC, l));
            }
        }

        /// <summary>
        /// Side Click Button EventHandler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SideClick(Object sender, RoutedEventArgs e)
        {
            if(DataContext is Order l)
            {
                mw.swapScreen(new Sides(mw, CC, l));
            }
            
        }

        /// <summary>
        /// Drink click eventhandler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DrinkiClick(Object sender, RoutedEventArgs e)
        {
            if (DataContext is Order l)
            {
                mw.swapScreen(new Drink(mw, CC, l));
            }
        }

        void CancelClick(Object sender, RoutedEventArgs e)
        {

        }

        void MenuClick(Object sender, RoutedEventArgs e)
        {
            mw.swapScreen(new ButtonControl(mw));
        }
    }
}
