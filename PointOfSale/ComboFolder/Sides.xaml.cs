using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
using PointOfSale.Sides;
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
    /// Interaction logic for Sides.xaml
    /// </summary>
    public partial class Sides : UserControl
    {

        public MainWindow mw
        { get; set; }
        private ComboClass CC;

        public Sides(MainWindow sw, ComboClass cc, Order l)
        {
            InitializeComponent();
            mw = sw;
            CC = cc;
            DataContext = l;
        }

        void DWFClick(Object sender, RoutedEventArgs e)
        {
            DragonbornWaffleFries bb = new DragonbornWaffleFries();
            if (DataContext is Order l)
            {
                CC.Side = bb;
                mw.swapScreen(new CustomDragonbornWaffleFries(mw, CC, bb, l));
            }
        }
        void FMClick(Object sender, RoutedEventArgs e)
        {
            FriedMiraak bb = new FriedMiraak();
            if (DataContext is Order l)
            {
                CC.Side = bb;
                mw.swapScreen(new CustomFriedMiraak(mw, CC, bb, l));
            }
        }
        void MGClick(Object sender, RoutedEventArgs e)
        {
            MadOtarGrits bb = new MadOtarGrits();
            if (DataContext is Order l)
            {
                CC.Side = bb;
                mw.swapScreen(new CustomMadOtarGrits(mw, CC, bb, l));
            }
        }
        void VSClick(Object sender, RoutedEventArgs e)
        {
            VokunSalad bb = new VokunSalad();
            if (DataContext is Order l)
            {
                CC.Side = bb;
                mw.swapScreen(new CustomVokunSalad(mw, CC, bb, l));
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
