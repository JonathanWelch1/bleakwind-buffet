using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Entrees;
using PointOfSale.Cash_Register;
using RoundRegister;
using PointOfSale;
using BleakwindBuffet.Data.Sides;
using System;

namespace BleakwindBuffet.DataTests
{
    public class CashRegisterViewModelTest
    {
        [Fact]
        public void ShouldBeACashRegister ()
        {
            CashRegisterViewModelClass cr = new CashRegisterViewModelClass(null, null);
            Assert.IsAssignableFrom<CashRegisterViewModelClass>(cr);
        }

        [Fact]
        public void ChargingPaymentHundredShouldNotify()
        {
            Order o = new Order();
            BriarheartBurger BB = new BriarheartBurger();
            o.Add(BB);
            CashRegisterViewModelClass cr = new CashRegisterViewModelClass(null, o);

            Assert.PropertyChanged(cr, "PaymentHundreds", () =>
            {
                cr.PaymentHundreds++;
            });
            Assert.PropertyChanged(cr, "AmountOwed", () =>
            {
                cr.PaymentHundreds++;
            });
            Assert.PropertyChanged(cr, "ChangeOwe", () =>
            {
                cr.PaymentHundreds++;
            });
            Assert.PropertyChanged(cr, "AmountOwedDisplayed", () =>
            {
                cr.PaymentHundreds++;
            });
        }

        [Fact]
        public void ChargingPaymentTwentiesShouldNotify()
        {
            Order o = new Order();
            BriarheartBurger BB = new BriarheartBurger();
            o.Add(BB);
            CashRegisterViewModelClass cr = new CashRegisterViewModelClass(null, o);

            Assert.PropertyChanged(cr, "PaymentFifties", () =>
            {
                cr.PaymentFifties++;
            });
        }

        [Fact]
        public void ChargingPaymentTensShouldNotify()
        {
            Order o = new Order();
            BriarheartBurger BB = new BriarheartBurger();
            o.Add(BB);
            CashRegisterViewModelClass cr = new CashRegisterViewModelClass(null, o);

            Assert.PropertyChanged(cr, "PaymentTwenties", () =>
            {
                cr.PaymentTwenties++;
            });
        }


        [Fact]
        public void ChargingPaymentFivesShouldNotify()
        {
            Order o = new Order();
            BriarheartBurger BB = new BriarheartBurger();
            o.Add(BB);
            CashRegisterViewModelClass cr = new CashRegisterViewModelClass(null, o);

            Assert.PropertyChanged(cr, "PaymentFives", () =>
            {
                cr.PaymentFives++;
            });
        }


        [Fact]
        public void ChargingPaymentTwosShouldNotify()
        {
            Order o = new Order();
            BriarheartBurger BB = new BriarheartBurger();
            o.Add(BB);
            CashRegisterViewModelClass cr = new CashRegisterViewModelClass(null, o);

            Assert.PropertyChanged(cr, "PaymentTwos", () =>
            {
                cr.PaymentTwos++;
            });
        }


        [Fact]
        public void ChargingPaymentOnesShouldNotify()
        {
            Order o = new Order();
            BriarheartBurger BB = new BriarheartBurger();
            o.Add(BB);
            CashRegisterViewModelClass cr = new CashRegisterViewModelClass(null, o);

            Assert.PropertyChanged(cr, "PaymentOnes", () =>
            {
                cr.PaymentOnes++;
            });
        }

        [Fact]
        public void ChargingPaymentHalfDollarsShouldNotify()
        {
            Order o = new Order();
            BriarheartBurger BB = new BriarheartBurger();
            o.Add(BB);
            CashRegisterViewModelClass cr = new CashRegisterViewModelClass(null, o);

            Assert.PropertyChanged(cr, "PaymentHalfDollars", () =>
            {
                cr.PaymentHalfDollars++;
            });
        }

        [Fact]
        public void ChargingPaymentQuartersShouldNotify()
        {
            Order o = new Order();
            BriarheartBurger BB = new BriarheartBurger();
            o.Add(BB);
            CashRegisterViewModelClass cr = new CashRegisterViewModelClass(null,o);

            Assert.PropertyChanged(cr, "PaymentQuarters", () =>
            {
                cr.PaymentQuarters++;
            });
        }

        [Fact]
        public void ChargingPaymentDimesShouldNotify()
        {
            Order o = new Order();
            BriarheartBurger BB = new BriarheartBurger();
            o.Add(BB);
            CashRegisterViewModelClass cr = new CashRegisterViewModelClass(null, o);

            Assert.PropertyChanged(cr, "PaymentDimes", () =>
            {
                cr.PaymentDimes++;
            });
        }

        [Fact]
        public void ChargingPaymentNickelsShouldNotify()
        {
            Order o = new Order();
            BriarheartBurger BB = new BriarheartBurger();
            o.Add(BB);
            CashRegisterViewModelClass cr = new CashRegisterViewModelClass(null, o);

            Assert.PropertyChanged(cr, "PaymentNickels", () =>
            {
                cr.PaymentNickels++;
            });
        }

        [Fact]
        public void ChargingPaymentPenniesShouldNotify()
        {
            Order o = new Order();
            BriarheartBurger BB = new BriarheartBurger();
            o.Add(BB);
            CashRegisterViewModelClass cr = new CashRegisterViewModelClass(null, o);

            Assert.PropertyChanged(cr, "PaymentPennies", () =>
            {
                cr.PaymentPennies++;
            });
        }

        [Theory]
        [InlineData(8.81)]
        public void ShouldSetAmountOwed(double a)
        {
            Order o = new Order();
            BriarheartBurger BB = new BriarheartBurger();
            AretinoAppleJuice aa = new AretinoAppleJuice();
            VokunSalad vs = new VokunSalad();
            o.Add(BB);
            o.Add(aa);
            o.Add(vs);
            CashRegisterViewModelClass cr = new CashRegisterViewModelClass(null, o);
            Assert.Equal(a, Math.Round(cr.AmountOwed, 2));
        }


        [Theory]
        [InlineData(8.81)]
        public void ShouldSetAmount(double a)
        {
            Order o = new Order();
            BriarheartBurger BB = new BriarheartBurger();
            AretinoAppleJuice aa = new AretinoAppleJuice();
            VokunSalad vs = new VokunSalad();
            o.Add(BB);
            o.Add(aa);
            o.Add(vs);
            CashRegisterViewModelClass cr = new CashRegisterViewModelClass(null, o);
            Assert.Equal(a, Math.Round(cr.AmountOwedDisplayed, 2));
        }



        [Theory]
        [InlineData(91.28, 1)]
        public void ShouldCalculateCorrectChange(double a, int payment)
        {
            Order o = new Order();
            BriarheartBurger BB = new BriarheartBurger();
            MarkarthMilk mm = new MarkarthMilk();
            DragonbornWaffleFries dd = new DragonbornWaffleFries();
            o.Add(BB);
            o.Add(mm);
            o.Add(dd);
            CashRegisterViewModelClass cr = new CashRegisterViewModelClass(null, o);
            cr.PaymentHundreds = payment;
            cr.ChangedOwedToCustomers();
         
            Assert.Equal(a, Math.Round(cr.ChangedOwe, 2));
            Assert.Equal(0, cr.PaymentHundreds);
            Assert.Equal(0, cr.PaymentFifties);
            Assert.Equal(4, cr.PaymentTwenties);
            Assert.Equal(1, cr.PaymentTens);
            Assert.Equal(0, cr.PaymentFives);
            Assert.Equal(0, cr.PaymentTwos);
            Assert.Equal(1, cr.PaymentOnes);
            Assert.Equal(0, cr.PaymentDollars);
            Assert.Equal(0, cr.PaymentHalfDollars);
            Assert.Equal(1, cr.PaymentQuarters);
            Assert.Equal(0, cr.PaymentDimes);
            Assert.Equal(0, cr.PaymentNickels);
            Assert.Equal(2, cr.PaymentPennies);
        }

        
    }
}
