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
    public class ComboClassTests
    {
        [Fact]
        public void ShouldBeCombo()
        {
            VokunSalad VB = new VokunSalad();
            SailorSoda SS = new SailorSoda();
            DoubleDraugr DD = new DoubleDraugr();

            VB.Size = Size.Large;

            ComboClass combo = new ComboClass(DD, SS, VB);
            Assert.IsAssignableFrom<ComboClass>(combo);
        }

        [Fact]
        public void ShouldReturnToString()
        {
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            AretinoAppleJuice aa = new AretinoAppleJuice();
            BriarheartBurger bb = new BriarheartBurger();
            dw.Size = Size.Large;
            ComboClass combo = new ComboClass(bb, aa, dw);
            Assert.Contains("Large Dragonborn Waffle Fries", combo.SpecialInstructions);
            Assert.Contains("Small Aretino Apple Juice", combo.SpecialInstructions);
            Assert.Contains("Briarheart Burger", combo.SpecialInstructions);

        }

        [Theory]
        [InlineData(Size.Small, 887)]
        [InlineData(Size.Medium, 931)]
        [InlineData(Size.Large, 975)]
        public void ShouldReturnCorrectCalories(Size s, uint cal)
        {
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            AretinoAppleJuice aa = new AretinoAppleJuice();
            BriarheartBurger bb = new BriarheartBurger();

            dw.Size = Size.Large;
            aa.Size = s;
            ComboClass combo = new ComboClass(bb, aa,dw );
            Assert.Equal(cal, combo.Calories);
        }
    }
}
