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
            if(DataContext is Order l )
            {
                l.Add(aj);
                mw.swapScreen(new CustomAretinoAppleJuice(mw, aj, l));
                
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
            if(DataContext is Order l)
            {
                l.Add(cc);
                mw.Border.Child = new CustomCandleHearthCoffee(mw, cc , l);
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
            if(DataContext is Order l)
            {
                l.Add(mm);
                mw.swapScreen(new CustomMarkathMilk(mw, mm, l));
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
            if(DataContext is Order l)
            {
                l.Add(bb);
                mw.swapScreen(new CustomBriarheartBurger(mw, bb , l));
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
            if(DataContext is Order l)
            {
                l.Add(dd);
                mw.swapScreen(new CustomDoubleDraugr(mw, dd, l));
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
            if (DataContext is Order l)
            {
                l.Add(go);
                mw.swapScreen(new CustomGardenOrcOmelette(mw, go , l));
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
            if(DataContext is Order l)
            {
                l.Add(pp);
                mw.swapScreen(new CustomPhillyPoacher(mw, pp , l));
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
            if(DataContext is Order l)
            {
                l.Add(ss);
                mw.swapScreen(new CustomSmokeHouseSkeleton(mw, ss, l));
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
            if(DataContext is Order l)
            {
                l.Add(tt);
                mw.swapScreen(new CustomThalmorTriple(mw, tt, l));
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
            if (DataContext is Order l)
            {
                l.Add(tt);
                mw.swapScreen(new CustomThugsTBone(mw, tt, l));
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
            if(DataContext is Order l)
            {
                l.Add(ss);
                mw.swapScreen(new CustomSailorSoda(mw, ss, l));
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
            if(DataContext is Order l)
            {
                l.Add(ww);
                mw.swapScreen(new CustomWarriorWater(mw, ww, l));
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
            if(DataContext is Order l)
            {
                l.Add(dw);
                mw.swapScreen(new CustomDragonbornWaffleFries(mw, dw, l));
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
            if(DataContext is Order l)
            {
                l.Add(fm);
                mw.swapScreen(new CustomFriedMiraak(mw, fm, l));
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
            if(DataContext is Order l)
            {
                l.Add(mm);
                mw.swapScreen(new CustomMadOtarGrits(mw, mm , l));
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
            if(DataContext is Order l)
            {
                l.Add(vs);
                mw.swapScreen(new CustomVokunSalad(mw, vs , l));
            }
            
        }
    }
}
