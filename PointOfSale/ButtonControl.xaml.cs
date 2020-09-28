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
        /// <summary>
        /// Switches Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AretinoAppleJuiceClick(object sender, RoutedEventArgs e)
        {
            mw.swapScreen(new CustomAretinoAppleJuice(mw));
        }
        /// <summary>
        /// Switches Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CC_Click(object sender, RoutedEventArgs e)
        {
            mw.Border.Child = new CustomCandleHearthCoffee(mw);
        }
        /// <summary>
        /// Switches Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BriarheartBurgerClick(object sender, RoutedEventArgs e)
        {
            mw.swapScreen(new CustomBriarheartBurger(mw));
        }
        /// <summary>
        /// Switches Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DoubleDraugrClick(object sender, RoutedEventArgs e)
        {
            mw.swapScreen(new CustomDoubleDraugr(mw));
        }
        /// <summary>
        /// Switches Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GardenOrcOmelleteClick(object sender, RoutedEventArgs e)
        {
            mw.swapScreen(new CustomGardenOrcOmelette(mw));
        }
        /// <summary>
        /// Switches Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhillyPoacherClick(object sender, RoutedEventArgs e)
        {
            mw.swapScreen(new CustomPhillyPoacher(mw));
        }
        /// <summary>
        /// Switches Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SmokehouseSkeletonClick(object sender, RoutedEventArgs e)
        {
            mw.swapScreen(new CustomSmokeHouseSkeleton(mw));
        }
        /// <summary>
        /// Switches Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThalmorTripleClick(object sender, RoutedEventArgs e)
        {
            mw.swapScreen(new CustomThalmorTriple(mw));
        }
        /// <summary>
        /// Switches Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThugsTBoneClick(object sender, RoutedEventArgs e)
        {

        }
        /// <summary>
        /// Switches Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MM_Click(object sender, RoutedEventArgs e)
        {
            mw.swapScreen(new CustomMarkathMilk(mw));
        }
        /// <summary>
        /// Switches Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SSF_Click(object sender, RoutedEventArgs e)
        {
            mw.swapScreen(new CustomSailorSoda(mw));
        }
        /// <summary>
        /// Switches Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WW_Click(object sender, RoutedEventArgs e)
        {
            mw.swapScreen(new CustomWarriorWater(mw));
        }
        /// <summary>
        /// Switches Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DragonbornWaffleFriesClick(object sender, RoutedEventArgs e)
        {
            mw.swapScreen(new CustomDragonbornWaffleFries(mw));
        }
        /// <summary>
        /// Switches Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FriedMiraakClick(object sender, RoutedEventArgs e)
        {
            mw.swapScreen(new FriedMiraak(mw));
        }
        /// <summary>
        /// Switches Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MadOtarGritsClick(object sender, RoutedEventArgs e)
        {
            mw.swapScreen(new MadOtarGrits(mw));
        }
        /// <summary>
        /// Switches Screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VokunSaladClick(object sender, RoutedEventArgs e)
        {
            mw.swapScreen(new CustomVokunSalad(mw));
        }
    }
}
