﻿using BleakwindBuffet.Data.Sides;
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

namespace PointOfSale.Sides
{
    /// <summary>
    /// Interaction logic for CustomDragonbornWaffleFries.xaml
    /// </summary>
    public partial class CustomDragonbornWaffleFries : UserControl
    {
        private MainWindow mw;
        private DragonbornWaffleFries DW;
        private Order _l;
        private ComboClass CC;
        /// <summary>
        /// Constructor for class
        /// </summary>
        /// <param name="sw">Main window being passed through</param>
        public CustomDragonbornWaffleFries(MainWindow sw, ComboClass cc,DragonbornWaffleFries dw, Order l)
        {
            InitializeComponent();
            DW = dw;
            _l = l;
            DataContext = DW;
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
                var itemRemoved = DW;
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
