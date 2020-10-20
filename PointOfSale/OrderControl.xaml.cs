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
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using PointOfSale.Drinks;
using PointOfSale.Entrees;
using PointOfSale.Sides;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        private MainWindow main;
        public OrderControl(MainWindow mw)
        {
            InitializeComponent();
            main = mw;
        }

        void Delete(object sender, RoutedEventArgs e)
        {

            Button b = (Button)sender;
            IOrderItem i = (IOrderItem)b.DataContext;
            if(DataContext is Order o)
            {
               
                var itemRemoved = i;
                o.Remove(itemRemoved);
            }
        }



        void EditItem(object sender, RoutedEventArgs e)
        {
            ComboClass C = new ComboClass(null, null, null);
            Button b = (Button)sender;
            IOrderItem i = (IOrderItem)b.DataContext;
            if (DataContext is Order o)
            {
                var itemToBeEdited = i;
                if(itemToBeEdited is BriarheartBurger bb)
                {

                    main.swapScreen(new CustomBriarheartBurger(main, C, bb, o));
                }
                if (itemToBeEdited is DoubleDraugr dd)
                {

                    main.swapScreen(new CustomDoubleDraugr(main, C, dd, o));
                }
                if (itemToBeEdited is GardenOrcOmelette go)
                {

                    main.swapScreen(new CustomGardenOrcOmelette(main, C, go, o));
                }
                if (itemToBeEdited is PhillyPoacher pp)
                {

                    main.swapScreen(new CustomPhillyPoacher(main,C, pp, o));
                }
                if (itemToBeEdited is SmokehouseSkeleton SS)
                {
                    main.swapScreen(new CustomSmokeHouseSkeleton(main, C, SS, o));
                }
                if (itemToBeEdited is ThalmorTriple TT)
                {
                    main.swapScreen(new CustomThalmorTriple(main, C, TT, o));
                }
                if (itemToBeEdited is DragonbornWaffleFries DW)
                {
                    main.swapScreen(new CustomDragonbornWaffleFries(main, C, DW, o));
                }
                if (itemToBeEdited is FriedMiraak FM)
                {
                    main.swapScreen(new CustomFriedMiraak(main, C, FM, o));
                }
                if (itemToBeEdited is MadOtarGrits MM)
                {
                    main.swapScreen(new CustomMadOtarGrits(main, C, MM, o));
                }
                if (itemToBeEdited is AretinoAppleJuice AA)
                {
                    main.swapScreen(new CustomAretinoAppleJuice(main, C, AA, o));
                }
                if (itemToBeEdited is CandlehearthCoffee CC)
                {
                    main.swapScreen(new CustomCandleHearthCoffee(main, C, CC, o));
                }
                if (itemToBeEdited is MarkarthMilk MI)
                {
                    main.swapScreen(new CustomMarkathMilk(main, C, MI, o));
                }
                if (itemToBeEdited is SailorSoda S)
                {
                    main.swapScreen(new CustomSailorSoda(main, C, S, o));
                }
                if (itemToBeEdited is WarriorWater WW)
                {
                    main.swapScreen(new CustomWarriorWater(main, C, WW, o));
                }
            }
        }
    }
}
