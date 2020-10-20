using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashRegister.xaml
    /// </summary>
    public partial class CashRegister : UserControl
    {
        private MainWindow mw;
        private Order O;
        private OrderControl OC;
        public CashRegister(MainWindow sw, Order o, OrderControl oc)
        {
            InitializeComponent();
            mw = sw;
            DataContext = o;
            TotalSaleTextBlock.Text = String.Format("{0:0.00}", o.Total);
            DataContext = new CashRegisterViewModelClass(this, o);
            O = o;
            OC = oc;
        }

        private void GoBackClick_Click(object sender, RoutedEventArgs e)
        {
            mw.swapScreen(new ButtonControl(mw));
        }

        private void FinalizeSaleClickEvent(object sender, RoutedEventArgs e)
        {
            if(DataContext is CashRegisterViewModelClass crvm)
            {
                crvm.FinalizeSale();
            }
            O.Clear();
            mw.swapScreen(new ButtonControl(mw));
            DependencyObject p = mw;
            do
            {
                p = LogicalTreeHelper.GetParent(p);
            } while (p != null && !(p is MainWindow));
            ((MainWindow)p).DataContext = new Order();
        }

        
    }
}
