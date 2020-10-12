/*
 * Author: Zachery Brunner
 * Class: AretinoAppleJuiceTests.cs
 * Purpose: Test the AretinoAppleJuice.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class OrderTests
    {
        [Fact]
        public void ShouldBeAnOrder()
        {
            Order order = new Order();
            Assert.IsAssignableFrom<Order>(order);
        }  

        [Fact]
        public void ShouldAddOrder()
        {
            VokunSalad VB = new VokunSalad();
            MarkarthMilk MM = new MarkarthMilk();
            DoubleDraugr DD = new DoubleDraugr();

            VB.Size = Size.Large;

            ComboClass combo = new ComboClass(DD, MM, VB);
            Order order = new Order();
            order.Add(VB);
            order.Add(MM);
            order.Add(DD);
            order.Add(combo);
            Assert.Contains(VB, order.order);
            Assert.Contains(MM, order.order);
            Assert.Contains(DD, order.order);
            Assert.Contains(combo, order.order);
        }

        [Fact]
        public void ShouldBeCorrectSalesTax()
        {
            Order order = new Order();
            Assert.Equal(.12, order.SalesTaxRate);
        }
    
        [Theory]
        [InlineData(.20)]
        [InlineData(.22)]
        public void ShouldSetSalesTaxRate(double salesTax)
        {
            Order order = new Order();
            order.SalesTaxRate = salesTax;
            Assert.Equal(salesTax, order.SalesTaxRate);
        }
    }
}
