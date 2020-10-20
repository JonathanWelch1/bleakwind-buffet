using BleakwindBuffet.Data;
using RoundRegister;
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

namespace PointOfSale.Cash_Register
{
    /// <summary>
    /// Interaction logic for PaymentScreen.xaml
    /// </summary>
    public partial class PaymentScreen : UserControl
    {

        private MainWindow mw;
        private Order O;
        private OrderControl OC;
        private CashRegisterViewModelClass CR;
        public PaymentScreen(MainWindow sw, Order o, OrderControl oc, CashRegisterViewModelClass cr)
        {
            InitializeComponent();
            mw = sw;
            O = o;
            OC = oc;
            CR = cr;
        }

        private void CreditCardClick(object sender, RoutedEventArgs e)
        {
  
            if(DataContext is Order o)
            {
                var r = CardReader.RunCard(o.Total);
                if (r == CardTransactionResult.Approved)
                {

                    o.Clear();
                    mw.swapScreen(new ButtonControl(mw));
                    CR.PrintReciept();
                    DependencyObject p = mw;
                    do
                    {
                        p = LogicalTreeHelper.GetParent(p);
                    } while (p != null && !(p is MainWindow));
                    ((MainWindow)p).DataContext = new Order();
                }
                else if (r == CardTransactionResult.Declined)
                {
                    MessageBox.Show("Declined");
                }
                else if (r == CardTransactionResult.ReadError)
                {
                    MessageBox.Show("Read Error");
                }
                else if (r == CardTransactionResult.InsufficientFunds)
                {
                    MessageBox.Show("Insufficient Funds");
                }
                else
                {
                    MessageBox.Show("Incorrect Pin");
                }
            }
        }

        private void CashClick(object sender, RoutedEventArgs e)
        {
            mw.swapScreen(new CashRegister(mw, O, OC));
        }

        private void GoBackClick(object sender, RoutedEventArgs e)
        {
            mw.swapScreen(new ButtonControl(mw));
        }
    }
}
