using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using PointOfSale.Entrees;
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
    /// Interaction logic for Entree.xaml
    /// </summary>
    public partial class Entree : UserControl
    {

        public MainWindow mw
        { get; set; }

        private ComboClass CC;
        public Entree(MainWindow sw, ComboClass cc, Order l)
        {
            InitializeComponent();
            mw = sw;
            CC = cc;
            DataContext = l;
        }

        void BriarheartBurgerClick(Object sender, RoutedEventArgs e)
        {
            BriarheartBurger bb = new BriarheartBurger();
            if (DataContext is Order l)
            {
                CC.Entree = bb;
                mw.swapScreen(new CustomBriarheartBurger(mw, CC, bb, l));
            }
        }
        void DoubleDraugrClick(Object sender, RoutedEventArgs e)
        {
            DoubleDraugr dd = new DoubleDraugr();
            if (DataContext is Order l)
            {
                CC.Entree = dd;
                mw.swapScreen(new CustomDoubleDraugr(mw, CC, dd, l));
            }
        }
        void GardenOrcClick(Object sender, RoutedEventArgs e) 
        {
            GardenOrcOmelette bb = new GardenOrcOmelette();
            if (DataContext is Order l)
            {
                CC.Entree = bb;
                mw.swapScreen(new CustomGardenOrcOmelette(mw, CC, bb, l));
            }
        }
        void PhillyPoacherClick(Object sender, RoutedEventArgs e)
        {
            PhillyPoacher bb = new PhillyPoacher();
            if (DataContext is Order l)
            {
                CC.Entree = bb;
                mw.swapScreen(new CustomPhillyPoacher(mw, CC, bb, l));
            }
        }
        void SmokehouseClick(Object sender, RoutedEventArgs e)
        {
            SmokehouseSkeleton bb = new SmokehouseSkeleton();
            if (DataContext is Order l)
            {
                CC.Entree = bb;
                mw.swapScreen(new CustomSmokeHouseSkeleton(mw, CC, bb, l));
            }
        }
        void ThalmorTripClick(Object sender, RoutedEventArgs e)
        {
            ThalmorTriple bb = new ThalmorTriple();
            if (DataContext is Order l)
            {
                CC.Entree = bb;
                mw.swapScreen(new CustomThalmorTriple(mw, CC, bb, l));
            }
        }
        void ThugsTboneClick(Object sender, RoutedEventArgs e)
        {
            ThugsTBone bb = new ThugsTBone();
            if (DataContext is Order l)
            {
                CC.Entree = bb;
                mw.swapScreen(new CustomThugsTBone(mw, CC, bb, l));
            }
        }
        void BackClick(Object sender, RoutedEventArgs e)
        {
            if(DataContext is Order o)
            {
                mw.swapScreen(new ComboMainScreen(mw, CC, o));
            }
        }
    }
}
