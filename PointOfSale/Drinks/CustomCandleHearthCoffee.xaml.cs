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

namespace PointOfSale.Drinks
{
    /// <summary>
    /// Interaction logic for CustomCandleHearthCoffee.xaml
    /// </summary>
    public partial class CustomCandleHearthCoffee : UserControl
    {
        private MainWindow mw;
        /// <summary>
        /// Constructor for class
        /// </summary>
        /// <param name="sw">Main window being passed through</param>
        public CustomCandleHearthCoffee(MainWindow sw)
        {
            InitializeComponent();
            mw = sw;
        }
        /// <summary>
        /// Switches Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mw.swapScreen(new ButtonControl(mw));
        }
        /// <summary>
        /// Switches Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            mw.swapScreen(new ButtonControl(mw));
        }
    }
}