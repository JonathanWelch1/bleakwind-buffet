using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Constructor for class
        /// </summary>
        public MainWindow()
        {
            
            InitializeComponent();
            ButtonControl e = new ButtonControl(this);
            OrderControl orderReceit = new OrderControl(this);
            OrderReceit.Child = orderReceit;
            DataContext = new Order();
            Border.Child = e;
            e.mw = this;
        }
        /// <summary>
        /// Method that swaps screens
        /// </summary>
        /// <param name="e">A frame work element screen</param>
        public void swapScreen(FrameworkElement e)
        {
            Border.Child = e;
        }
    }
}
