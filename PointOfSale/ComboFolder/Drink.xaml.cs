using PointOfSale.Drinks;
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
using BleakwindBuffet.Data.Drinks;
namespace PointOfSale.ComboFolder
{
    /// <summary>
    /// Interaction logic for Drink.xaml
    /// </summary>
    public partial class Drink : UserControl
    {

        public MainWindow mw
        { get; set; }
        private ComboClass CC;

        public Drink(MainWindow sw, ComboClass cc, Order l)
        {
            InitializeComponent();
            mw = sw;
            CC = cc;
            DataContext = l;
        }


        void AAClick(Object sender, RoutedEventArgs e)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            if (DataContext is Order l)
            {
                CC.Drink = aj;
                mw.swapScreen(new CustomAretinoAppleJuice(mw, CC, aj, l));
            }
        }
        void CCClick(Object sender, RoutedEventArgs e)
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            if(DataContext is Order l)
            {
                CC.Drink = cc;
                mw.swapScreen(new CustomCandleHearthCoffee(mw, CC, cc ,l));
            }
    
        }
        void MMClick(Object sender, RoutedEventArgs e)
        {
            MarkarthMilk mm = new MarkarthMilk();
            if (DataContext is Order l)
            {
                CC.Drink = mm;
                mw.swapScreen(new CustomMarkathMilk(mw, CC, mm, l));
            }
        }
        void SSClick(Object sender, RoutedEventArgs e)
        {
            SailorSoda ss = new SailorSoda();
            if (DataContext is Order l)
            {
                CC.Drink = ss;
                mw.swapScreen(new CustomSailorSoda(mw, CC, ss,l));
            }
        }
        void WWClick(Object sender, RoutedEventArgs e)
        {
            WarriorWater ww = new WarriorWater();
            if (DataContext is Order l)
            {
                CC.Drink = ww;
                mw.swapScreen(new CustomWarriorWater(mw, CC, ww, l));
            }
        }

        void GoBackClick(Object sender, RoutedEventArgs e)
        {
            if(DataContext is Order o)
            {
                mw.swapScreen(new ComboMainScreen(mw, CC, o));
            }
        }
    }
}
