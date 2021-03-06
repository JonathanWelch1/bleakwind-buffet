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
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using PointOfSale.ComboFolder;

namespace PointOfSale.Entrees
{
    /// <summary>
    /// Interaction logic for CustomThugsTBone.xaml
    /// </summary>
    public partial class CustomThugsTBone : UserControl
    {

        private MainWindow mw;
        private ThugsTBone TT;
        private Order _l;
        private ComboClass CC;
        public CustomThugsTBone(MainWindow sw, ComboClass cc,ThugsTBone tt, Order l)
        {
            InitializeComponent();
            mw = sw;
            TT = tt;
            _l = l;
            DataContext = TT;
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

