using PointOfSale.Drinks;
using PointOfSale.Entrees;
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
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System.Threading;
using PointOfSale.ComboFolder;
using PointOfSale.Cash_Register;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for Entree.xaml
    /// </summary>
    public partial class ButtonControl : UserControl
    {

        
        public MainWindow mw
        {
            get; set;        
        }
        /// <summary>
        /// Constructor for class
        /// </summary>
        /// <param name="sw">Main window being passed through</param>
        public ButtonControl(MainWindow sw)
        {
            InitializeComponent();
            mw = sw;
        }

        void PaymentOptionsClick(object sender, RoutedEventArgs e)
        {
            
            if(DataContext is Order l)
            {
                OrderControl oc = new OrderControl(mw);
                CashRegister cr = new CashRegister(mw, l, oc);
                CashRegisterViewModelClass Cr = new CashRegisterViewModelClass(cr, l); 
                mw.swapScreen(new PaymentScreen(mw, l , oc, Cr));
            }
            
        }

        void CancelOrderClick(object sender, RoutedEventArgs e)
        {
            DependencyObject Parent = this;
            Order o = (Order)DataContext;
            o.Clear();
            DataContext = o;
        }

        void newOrderClick(object sender, RoutedEventArgs e)
        {
            DependencyObject Parent = this;
            do
            {
                Parent = LogicalTreeHelper.GetParent(Parent);
            } while (Parent != null && !(Parent is MainWindow));
            ((MainWindow)Parent).DataContext = new Order();
        }

        /// <summary>
        /// Switches Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AretinoAppleJuiceClick(object sender, RoutedEventArgs e)
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            ComboClass CC = new ComboClass(null, null, null);
            if(DataContext is Order l )
            {
                l.Add(aj);
                mw.swapScreen(new CustomAretinoAppleJuice(mw, CC, aj, l));
            }
            
        }
        /// <summary>
        /// Switches Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CC_Click(object sender, RoutedEventArgs e)
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            ComboClass CC = new ComboClass(null, null, null);
            if (DataContext is Order l)
            {
                l.Add(cc);
                mw.Border.Child = new CustomCandleHearthCoffee(mw, CC,  cc , l);
            }
            
        }

        /// <summary>
        /// Switches Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MM_Click(object sender, RoutedEventArgs e)
        {
            MarkarthMilk mm = new MarkarthMilk();
            ComboClass CC = new ComboClass(null, null, null);
            if (DataContext is Order l)
            {
                l.Add(mm);
                mw.swapScreen(new CustomMarkathMilk(mw, CC, mm, l));
            }
            
        }
        /// <summary>
        /// Switches Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BriarheartBurgerClick(object sender, RoutedEventArgs e)
        {
            BriarheartBurger bb = new BriarheartBurger();
            ComboClass CC = new ComboClass(null, null, null);
            if (DataContext is Order l)
            {
                l.Add(bb);
                mw.swapScreen(new CustomBriarheartBurger(mw, CC, bb , l));
            }
            
        }
        /// <summary>
        /// Switches Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DoubleDraugrClick(object sender, RoutedEventArgs e)
        {
            DoubleDraugr dd = new DoubleDraugr();
            ComboClass CC = new ComboClass(null, null, null);
            if (DataContext is Order l)
            {
                l.Add(dd);
                mw.swapScreen(new CustomDoubleDraugr(mw, CC, dd, l));
            }
            
        }
        /// <summary>
        /// Switches Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GardenOrcOmelleteClick(object sender, RoutedEventArgs e)
        {
            GardenOrcOmelette go = new GardenOrcOmelette();
            ComboClass CC = new ComboClass(null, null, null);
            if (DataContext is Order l)
            {
                l.Add(go);
                mw.swapScreen(new CustomGardenOrcOmelette(mw, CC, go , l));
            }
            
        }
        /// <summary>
        /// Switches Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhillyPoacherClick(object sender, RoutedEventArgs e)
        {

            PhillyPoacher pp = new PhillyPoacher();
            ComboClass CC = new ComboClass(null, null, null);
            if (DataContext is Order l)
            {
                l.Add(pp);
                mw.swapScreen(new CustomPhillyPoacher(mw, CC, pp , l));
            }
            
        }
        /// <summary>
        /// Switches Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SmokehouseSkeletonClick(object sender, RoutedEventArgs e)
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ComboClass CC = new ComboClass(null, null, null);
            if (DataContext is Order l)
            {
                l.Add(ss);
                mw.swapScreen(new CustomSmokeHouseSkeleton(mw, CC, ss, l));
            }
            
        }
        /// <summary>
        /// Switches Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThalmorTripleClick(object sender, RoutedEventArgs e)
        {
            ThalmorTriple tt = new ThalmorTriple();
            ComboClass CC = new ComboClass(null, null, null);
            if (DataContext is Order l)
            {
                l.Add(tt);
                mw.swapScreen(new CustomThalmorTriple(mw, CC,  tt, l));
            }
            
        }
        /// <summary>
        /// Switches Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThugsTBoneClick(object sender, RoutedEventArgs e)
        {
            ThugsTBone tt = new ThugsTBone();
            ComboClass CC = new ComboClass(null, null, null);
            if (DataContext is Order l)
            {
                l.Add(tt);
                mw.swapScreen(new CustomThugsTBone(mw, CC, tt, l));
            }
        }

        /// <summary>
        /// Switches Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SSF_Click(object sender, RoutedEventArgs e)
        {
            SailorSoda ss = new SailorSoda();
            ComboClass CC = new ComboClass(null, null, null);
            if (DataContext is Order l)
            {
                l.Add(ss);
                mw.swapScreen(new CustomSailorSoda(mw, CC, ss, l));
            }
            
        }
        /// <summary>
        /// Switches Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WW_Click(object sender, RoutedEventArgs e)
        {
            WarriorWater ww = new WarriorWater();
            ComboClass CC = new ComboClass(null, null, null);
            if (DataContext is Order l)
            {
                l.Add(ww);
                mw.swapScreen(new CustomWarriorWater(mw, CC, ww, l));
            }
            
        }
        /// <summary>
        /// Switches Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DragonbornWaffleFriesClick(object sender, RoutedEventArgs e)
        {
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            ComboClass CC = new ComboClass(null, null, null);
            if (DataContext is Order l)
            {
                l.Add(dw);
                mw.swapScreen(new CustomDragonbornWaffleFries(mw, CC, dw, l));
            }
            
        }
        /// <summary>
        /// Switches Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FriedMiraakClick(object sender, RoutedEventArgs e)
        {
            FriedMiraak fm = new FriedMiraak();
            ComboClass CC = new ComboClass(null, null, null);
            if (DataContext is Order l)
            {
                l.Add(fm);
                mw.swapScreen(new CustomFriedMiraak(mw, CC, fm, l));
            }
            
        }
        /// <summary>
        /// Switches Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MadOtarGritsClick(object sender, RoutedEventArgs e)
        {
            MadOtarGrits mm = new MadOtarGrits();
            ComboClass CC = new ComboClass(null, null, null);
            if (DataContext is Order l)
            {
                l.Add(mm);
                mw.swapScreen(new CustomMadOtarGrits(mw, CC, mm , l));
            }

        }
        /// <summary>
        /// Switches Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VokunSaladClick(object sender, RoutedEventArgs e)
        {
            VokunSalad vs = new VokunSalad();
            ComboClass CC = new ComboClass(null, null, null);
            if (DataContext is Order l)
            {
                l.Add(vs);
                mw.swapScreen(new CustomVokunSalad(mw, CC, vs , l));
            }
            
        }

        private void CreateComboClick(object sender, RoutedEventArgs e)
        {
            ComboClass comboClass = new ComboClass(new DoubleDraugr(), new SailorSoda(), new VokunSalad());
            if(DataContext is Order l)
            {
                l.Add(comboClass);
                mw.swapScreen(new ComboMainScreen(mw, comboClass, l));
            }
        }
    }
}
