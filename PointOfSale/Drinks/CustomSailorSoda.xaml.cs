﻿using System;
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
using Flavor = BleakwindBuffet.Data.Enums.SodaFlavor;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data;
using PointOfSale.ComboFolder;

namespace PointOfSale.Drinks
{
    /// <summary>
    /// Interaction logic for CustomSailorSoda.xaml
    /// </summary>
    public partial class CustomSailorSoda : UserControl
    {
        private MainWindow mw;
        private SailorSoda SS;
        private Order _l;
        private ComboClass CC;
        /// <summary>
        /// Constructor for class
        /// </summary>
        /// <param name="sw">Main window being passed through</param>
        public CustomSailorSoda(MainWindow sw, ComboClass cc, SailorSoda ss, Order l)
        {
            InitializeComponent();
            SS = ss;
            _l = l;
            DataContext = SS;
            mw = sw;
            CC = cc;
        }
        /// <summary>
        /// Switches Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelClick(object sender, RoutedEventArgs e)
        {
            mw.swapScreen(new ButtonControl(mw));
            DataContext = _l;
            if (DataContext is Order o)
            {
                var itemRemoved = SS;
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
                SS.Size = s;
                DataContext = SS;
            }
        }

        void checkBoxFlavorChecked(Object sender, RoutedEventArgs e)
        {
            Flavor f;
            if(sender is CheckBox cb)
            {
                switch (cb.Name)
                {
                    case "Blackberry":
                        f = Flavor.Blackberry;
                        Blackberry.IsChecked = true;
                        Cherry.IsChecked = false;
                        Grapefruit.IsChecked = false;
                        Lemon.IsChecked = false;
                        Peach.IsChecked = false;
                        Watermelon.IsChecked = false;
                        break;
                    case "Cherry":
                        f = Flavor.Cherry;
                        Blackberry.IsChecked = false;
                        Cherry.IsChecked = true;
                        Grapefruit.IsChecked = false;
                        Lemon.IsChecked = false;
                        Peach.IsChecked = false;
                        Watermelon.IsChecked = false;
                        break;
                    case "Grapefruit":
                        f = Flavor.Grapefruit;
                        Blackberry.IsChecked = false;
                        Cherry.IsChecked = false;
                        Grapefruit.IsChecked = true;
                        Lemon.IsChecked = false;
                        Peach.IsChecked = false;
                        Watermelon.IsChecked = false;
                        break;
                    case "Lemon":
                        f = Flavor.Lemon;
                        Blackberry.IsChecked = false;
                        Cherry.IsChecked = false;
                        Grapefruit.IsChecked = false;
                        Lemon.IsChecked = true;
                        Peach.IsChecked = false;
                        Watermelon.IsChecked = false;
                        break;
                    case "Peach":
                        f = Flavor.Peach;
                        Blackberry.IsChecked = false;
                        Cherry.IsChecked = false;
                        Grapefruit.IsChecked = false;
                        Lemon.IsChecked = false;
                        Peach.IsChecked = true;
                        Watermelon.IsChecked = false;
                        break;
                    case "Watermelon":
                        f = Flavor.Watermelon;
                        Blackberry.IsChecked = false;
                        Cherry.IsChecked = false;
                        Grapefruit.IsChecked = false;
                        Lemon.IsChecked = false;
                        Peach.IsChecked = false;
                        Watermelon.IsChecked = true;
                        break;
                    default:
                        throw new NotImplementedException();
                }
                SS.Flavor = f;
                DataContext = SS;
            }
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
