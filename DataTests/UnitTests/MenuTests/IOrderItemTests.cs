using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.MenuTests
{
    public class IOrderItemTests
    {
        [Fact]
        public void ShouldbeAssignableToAbstractDrinkClass()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            Assert.IsAssignableFrom<IOrderItem>(aj);
            Assert.IsAssignableFrom<Drink>(aj);

            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.IsAssignableFrom<IOrderItem>(cc);
            Assert.IsAssignableFrom<Drink>(cc);

            MarkarthMilk mm = new MarkarthMilk();
            Assert.IsAssignableFrom<IOrderItem>(mm);
            Assert.IsAssignableFrom<Drink>(mm);

            SailorSoda ss = new SailorSoda();
            Assert.IsAssignableFrom<IOrderItem>(ss);
            Assert.IsAssignableFrom<Drink>(ss);

            WarriorWater ww = new WarriorWater();
            Assert.IsAssignableFrom<IOrderItem>(ww);
            Assert.IsAssignableFrom<Drink>(ww);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractEntreeClass()
        {
            BriarheartBurger bb = new BriarheartBurger();
            Assert.IsAssignableFrom<IOrderItem>(bb);
            Assert.IsAssignableFrom<Entree>(bb);

            DoubleDraugr dd = new DoubleDraugr();
            Assert.IsAssignableFrom<IOrderItem>(dd);
            Assert.IsAssignableFrom<Entree>(dd);

            GardenOrcOmelette gg = new GardenOrcOmelette();
            Assert.IsAssignableFrom<IOrderItem>(gg);
            Assert.IsAssignableFrom<Entree>(gg);

            PhillyPoacher pp = new PhillyPoacher();
            Assert.IsAssignableFrom<IOrderItem>(pp);
            Assert.IsAssignableFrom<Entree>(pp);

            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<IOrderItem>(ss);
            Assert.IsAssignableFrom<Entree>(ss);

            ThalmorTriple tt = new ThalmorTriple();
            Assert.IsAssignableFrom<IOrderItem>(tt);
            Assert.IsAssignableFrom<Entree>(tt);

            ThugsTBone tb = new ThugsTBone();
            Assert.IsAssignableFrom<IOrderItem>(tb);
            Assert.IsAssignableFrom<Entree>(tb);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractSideClass()
        {
            DragonbornWaffleFries dd = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<IOrderItem>(dd);
            Assert.IsAssignableFrom<Side>(dd);

            FriedMiraak fm = new FriedMiraak();
            Assert.IsAssignableFrom<IOrderItem>(fm);
            Assert.IsAssignableFrom<Side>(fm);

            MadOtarGrits mg = new MadOtarGrits();
            Assert.IsAssignableFrom<IOrderItem>(mg);
            Assert.IsAssignableFrom<Side>(mg);

            VokunSalad vs = new VokunSalad();
            Assert.IsAssignableFrom<IOrderItem>(vs);
            Assert.IsAssignableFrom<Side>(vs);
        }

    }
}
