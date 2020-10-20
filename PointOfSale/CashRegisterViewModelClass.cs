using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using RoundRegister;
using System.Configuration;

namespace PointOfSale
{
    public class CashRegisterViewModelClass : INotifyPropertyChanged
    {

        /// <summary>
        /// public event for I notify Property
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Helper method for Property Change
        /// </summary>
        /// <param name="name">String that is passed in</param>
        protected void OnPropertyChange(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        /// <summary>
        /// private var for CashReg
        /// </summary>
        private CashRegister CR;
        /// <summary>
        /// for the Order
        /// </summary>
        private Order O;

        /// <summary>
        /// Constructor for class
        /// </summary>
        /// <param name="cr">Cash Register</param>
        /// <param name="o">ORder</param>
        public CashRegisterViewModelClass(CashRegister cr, Order o)
        {
            O = o;
            CR = cr;
        }

        /// <summary>
        /// gets the total
        /// </summary>
        public double Total
        {
            get
            {
                return O.Total;
            }
        }

        /// <summary>
        /// Determies what the customer pays
        /// </summary>
        public double CustomerPay
        {
            get
            {
                return (PaymentHundreds * 100) + (PaymentFifties * 50) + (PaymentTwenties * 20) + (PaymentTens * 10) + (PaymentFives * 5) + (PaymentTwos * 2) + (PaymentOnes * 1) + (PaymentDollars * 1) + (PaymentQuarters * .25) + (PaymentDimes * .1) + (PaymentNickels * .05) + (PaymentHalfDollars * .5) + (PaymentPennies * .01);
            }
        }

        /// <summary>
        /// gets and sets the Amoun owed
        /// </summary>
        public double AmountOwedDisplayed
        {

            get
            {
                if (AmountOwed < 0)
                {
                    return 0;
                }
                else
                {
                    return AmountOwed;
                }
            }
        }

        /// <summary>
        /// gets the amountOwed
        /// </summary>
        public double AmountOwed
        {
            get
            {
                return Total - CustomerPay;
            }
        }

        /// <summary>
        /// gets the changed owed
        /// </summary>
        public double ChangedOwe
        {
            get
            {
                if (CustomerPay - AmountOwed > 0)
                {
                    return Math.Abs(AmountOwed);
                }

                else
                {
                    return 0;
                }
            }
        }



        /// <summary>
        /// method for currency
        /// </summary>
        public int Hundreds
        {
            get
            {
                return CashDrawer.Hundreds;
            }
            set
            {
                CashDrawer.Hundreds = value;
                OnPropertyChange("Hundreds");
            }
        }
        /// <summary>
        /// backing var for hundred
        /// </summary>
        private int paymentHundreds = 0;

        /// <summary>
        /// gets and sets the hundred bill
        /// </summary>
        public int PaymentHundreds
        {
            get
            {
                return paymentHundreds;
            }

            set
            {
                if (paymentHundreds != value)
                {
                    paymentHundreds = value;
                    OnPropertyChange("PaymentHundreds");
                    OnPropertyChange("AmountOwed");
                    OnPropertyChange("ChangedOwe");
                    OnPropertyChange("AmountOwedDisplayed");
                    ChangedOwedToCustomers();
                }
            }
        }



        /// <summary>
        /// get and sets the value for fifites
        /// </summary>
        public int Fifties
        {
            get
            {
                return CashDrawer.Fifties;
            }

            set
            {
                CashDrawer.Fifties = value;
                OnPropertyChange("Fifties");
            }
        }
        /// <summary>
        /// private backing var for fifites
        /// </summary>
        private int paymentFifties = 0;
        /// <summary>
        /// get and sets the value for fities
        /// </summary>
        public int PaymentFifties
        {
            get
            {
                return paymentFifties;
            }
            set
            {
                if (paymentFifties != value)
                {
                    paymentFifties = value;
                    OnPropertyChange("PaymentFifties");
                    OnPropertyChange("AmountOwed");
                    OnPropertyChange("ChangedOwe");
                    OnPropertyChange("AmountOwedDisplayed");
                    ChangedOwedToCustomers();
                }
            }
        }


        /// <summary>
        /// gets and sets vals
        /// </summary>
        public int Twenties
        {
            get
            {
                return CashDrawer.Twenties;
            }

            set
            {
                CashDrawer.Twenties = value;
                OnPropertyChange("Twenties");
            }
        }
        /// <summary>
        /// backing var
        /// </summary>
        private int paymentTwenties = 0;


        /// <summary>
        /// SAME AS ABOVE
        /// </summary>
        public int PaymentTwenties
        {
            get
            {
                return paymentTwenties;
            }
            set
            {
                if (paymentTwenties != value)
                {
                    paymentTwenties = value;
                    OnPropertyChange("PaymentTwenties");
                    OnPropertyChange("AmountOwed");
                    OnPropertyChange("ChangedOwe");
                    OnPropertyChange("AmountOwedDisplayed");
                    ChangedOwedToCustomers();
                }
            }
        }


        /// <summary>
        /// SAME AS ABOVE
        /// </summary>
        public int Tens
        {
            get
            {
                return CashDrawer.Tens;
            }
            set
            {
                CashDrawer.Tens = value;
                OnPropertyChange("Tens");
            }
        }


        /// <summary>
        /// SAME AS ABOVE
        /// </summary>
        private int paymentTens = 0;

        /// <summary>
        /// SAME AS ABOVE
        /// </summary>
        public int PaymentTens
        {
            get
            {
                return paymentTens;
            }
            set
            {
                if (paymentTens != value)
                {
                    paymentTens = value;
                    OnPropertyChange("PaymentTens");
                    OnPropertyChange("AmountOwed");
                    OnPropertyChange("ChangedOwe");
                    OnPropertyChange("AmountOwedDisplayed");
                    ChangedOwedToCustomers();
                }
            }
        }

        /// <summary>
        /// SAME AS ABOVE
        /// </summary>
        public int Fives
        {
            get
            {
                return CashDrawer.Fives;
            }
            set
            {
                CashDrawer.Fives = value;
                OnPropertyChange("Fives");
            }
        }

        /// <summary>
        /// SAME AS ABOVE
        /// </summary>
        private int paymentFives = 0;

        /// <summary>
        /// SAME AS ABOVE
        /// </summary>
        public int PaymentFives
        {
            get
            {
                return paymentFives;
            }
            set
            {
                if (paymentFives != value)
                {
                    paymentFives = value;
                    OnPropertyChange("PaymentFives");
                    OnPropertyChange("AmountOwed");
                    OnPropertyChange("ChangedOwe");
                    OnPropertyChange("AmountOwedDisplayed");
                    ChangedOwedToCustomers();
                }
            }
        }

        /// <summary>
        /// SAME AS ABOVE
        /// </summary>
        public int Twos
        {
            get
            {
                return CashDrawer.Twos;
            }
            set
            {
                CashDrawer.Twos = value;
                OnPropertyChange("Twos");
            }
        }

        /// <summary>
        /// SAME AS ABOVE
        /// </summary>
        private int paymentTwos = 0;

        /// <summary>
        /// SAME AS ABOVE
        /// </summary>
        public int PaymentTwos
        {
            get
            {
                return paymentTwos;
            }
            set
            {
                if (paymentTwos != value)
                {
                    paymentTwos = value;
                    OnPropertyChange("PaymentTwos");
                    OnPropertyChange("AmountOwed");
                    OnPropertyChange("ChangedOwe");
                    OnPropertyChange("AmountOwedDisplayed");
                    ChangedOwedToCustomers();
                }
            }
        }

        /// <summary>
        /// SAME AS ABOVE
        /// </summary>
        public int Ones
        {
            get
            {
                return CashDrawer.Ones;
            }
            set
            {
                CashDrawer.Ones = value;
                OnPropertyChange("Ones");
            }
        }

        /// <summary>
        /// SAME AS ABOVE
        /// </summary>
        private int paymentOnes = 0;

        /// <summary>
        /// SAME AS ABOVE
        /// </summary>
        public int PaymentOnes
        {
            get
            {
                return paymentOnes;
            }
            set
            {
                if (paymentOnes != value)
                {
                    paymentOnes = value;
                    OnPropertyChange("PaymentOnes");
                    OnPropertyChange("AmountOwed");
                    OnPropertyChange("ChangedOwe");
                    OnPropertyChange("AmountOwedDisplayed");
                    ChangedOwedToCustomers();
                }
            }
        }

        /// <summary>
        /// SAME AS ABOVE
        /// </summary>
        public int Dollars
        {
            get
            {
                return CashDrawer.Dollars;
            }
            set
            {
                CashDrawer.Dollars = value;
                OnPropertyChange("Dollars");
            }
        }

        /// <summary>
        /// SAME AS ABOVE
        /// </summary>
        private int paymentDollars = 0;

        /// <summary>
        /// SAME AS ABOVE
        /// </summary>
        public int PaymentDollars
        {
            get
            {
                return paymentDollars;
            }
            set
            {
                if (paymentDollars != value)
                {
                    paymentDollars = value;
                    OnPropertyChange("PaymentDollars");
                    OnPropertyChange("AmountOwed");
                    OnPropertyChange("ChangedOwe");
                    OnPropertyChange("AmountOwedDisplayed");
                    ChangedOwedToCustomers();
                }
            }
        }

        /// <summary>
        /// SAME AS ABOVE
        /// </summary>
        public int HalfDollars
        {
            get
            {
                return CashDrawer.HalfDollars;
            }
            set
            {
                CashDrawer.HalfDollars = value;
                OnPropertyChange("HalfDollars");
            }
        }

        /// <summary>
        /// SAME AS ABOVE
        /// </summary>
        private int paymentHalfDollars = 0;

        /// <summary>
        /// SAME AS ABOVE
        /// </summary>
        public int PaymentHalfDollars
        {
            get
            {
                return paymentHalfDollars;
            }
            set
            {
                if (paymentHalfDollars != value)
                {
                    paymentHalfDollars = value;
                    OnPropertyChange("PaymentHalfDollars");
                    OnPropertyChange("AmountOwed");
                    OnPropertyChange("ChangedOwe");
                    OnPropertyChange("AmountOwedDisplayed");
                    ChangedOwedToCustomers();
                }
            }
        }


        /// <summary>
        /// SAME AS ABOVE
        /// </summary>
        public int Quarters
        {
            get
            {
                return CashDrawer.Quarters;
            }
            set
            {
                CashDrawer.Quarters = value;
                OnPropertyChange("Quarters");
            }
        }

        /// <summary>
        /// SAME AS ABOVE
        /// </summary>
        private int paymentQuarters = 0;

        /// <summary>
        /// SAME AS ABOVE
        /// </summary>
        public int PaymentQuarters
        {
            get { return paymentQuarters; }
            set
            {
                if (paymentQuarters != value)
                {
                    paymentQuarters = value;
                    OnPropertyChange("PaymentQuarters");
                    OnPropertyChange("AmountOwed");
                    OnPropertyChange("ChangedOwe");
                    OnPropertyChange("AmountOwedDisplayed");
                    ChangedOwedToCustomers();
                }
            }
        }


        /// <summary>
        /// SAME AS ABOVE
        /// </summary>
        public int Dimes
        {
            get
            {
                return CashDrawer.Dimes;
            }
            set
            {
                CashDrawer.Dimes = value;
                OnPropertyChange("Dimes");
            }
        }

        /// <summary>
        /// SAME AS ABOVE
        /// </summary>
        private int paymentDimes = 0;

        /// <summary>
        /// SAME AS ABOVE
        /// </summary>
        public int PaymentDimes
        {
            get
            {
                return paymentDimes;
            }
            set
            {
                if (paymentDimes != value)
                {
                    paymentDimes = value;
                    OnPropertyChange("PaymentDimes");
                    OnPropertyChange("AmountOwed");
                    OnPropertyChange("ChangedOwe");
                    OnPropertyChange("AmountOwedDisplayed");
                    ChangedOwedToCustomers();
                }
            }
        }

        /// <summary>
        /// SAME AS ABOVE
        /// </summary>
        public int Nickels
        {
            get
            {
                return CashDrawer.Nickels;
            }
            set
            {
                CashDrawer.Nickels = value;
                OnPropertyChange("Nickels");
            }
        }

        /// <summary>
        /// SAME AS ABOVE
        /// </summary>
        private int paymentNickels = 0;

        public int PaymentNickels
        {
            get
            {
                return paymentNickels;
            }
            set
            {
                if (paymentNickels != value)
                {
                    paymentNickels = value;
                    OnPropertyChange("PaymentNickels");
                    OnPropertyChange("AmountOwed");
                    OnPropertyChange("ChangedOwe");
                    OnPropertyChange("AmountOwedDisplayed");
                    ChangedOwedToCustomers();
                }
            }
        }

        /// <summary>
        /// SAME AS ABOVE
        /// </summary>
        public int Pennies
        {
            get
            {
                return CashDrawer.Pennies;
            }
            set
            {
                CashDrawer.Pennies = value;
                OnPropertyChange("Pennies");
            }
        }

        /// <summary>
        /// SAME AS ABOVE
        /// </summary>
        private int paymentPennies = 0;

        /// <summary>
        /// SAME AS ABOVE
        /// </summary>
        public int PaymentPennies
        {
            get
            {
                return paymentPennies;
            }

            set
            {
                if (paymentPennies != value)
                {
                    paymentPennies = value;
                    OnPropertyChange("PaymentPennies");
                    OnPropertyChange("AmountOwed");
                    OnPropertyChange("ChangedOwe");
                    OnPropertyChange("AmountOwedDisplayed");
                    ChangedOwedToCustomers();
                }
            }
        }

        private int changeHundreds = 0;

        public int ChangeHundreds
        {
            get
            {
                return changeHundreds;
            }
        }
        private int changeFifties = 0;

        public int ChangeFifties
        {
            get
            {
                return changeFifties;
            }
        }
        private int changeTwenties = 0;

        public int ChangeTwenties
        {
            get
            {
                return changeTwenties;
            }
        }
        private int changeTens = 0;

        public int ChangeTens
        {
            get
            {
                return changeTens;
            }
        }
        private int changeFives = 0;

        public int ChangeFives
        {
            get
            {
                return changeFives;
            }
        }
        private int changeTwos = 0;

        public int ChangeTwos
        {
            get
            {
                return changeTwos;
            }
        }

        private int changeOnes = 0;

        public int ChangeOnes
        {
            get
            {
                return changeOnes;
            }
        }
        private int changeDollars = 0;

        public int ChangeDollars
        {
            get
            {
                return changeDollars;
            }
        }
        private int changeHalfDollars = 0;

        public int ChangeHalfDolllars
        {
            get
            {
                return changeHalfDollars;
            }
        }
        private int changeQuarters = 0;

        public int ChangeQuarters
        {
            get
            {
                return changeQuarters;
            }
        }
        private int changeDimes = 0;

        public int ChangeDimes
        {
            get
            {
                return changeDimes;
            }
        }
        private int changeNickels = 0;

        public int ChangeNickels
        {
            get
            {
                return changeNickels;
            }
        }

        private int changePennies = 0;

        public int ChangePennies
        {
            get
            {
                return changePennies;
            }
        }
        /// <summary>
        /// Calculates the amount of change owed to the customer
        /// </summary>
        public void ChangedOwedToCustomers()
        {
            double originalAmount = ChangedOwe;
            double remainingAmount = originalAmount;
            int temp = Hundreds;
            changeHundreds = 0;
            changeFifties = 0;
            changeTwenties = 0;
            changeTens = 0;
            changeFives = 0;
            changeTwos = 0;
            changeOnes = 0;
            changeDollars = 0;
            changeHalfDollars = 0;
            changeQuarters = 0;
            changeDimes = 0;
            changeNickels = 0;
            changePennies = 0;

            while ((originalAmount % 100) < originalAmount && temp > 0)
            {
                if (originalAmount - 100 > 0)
                {
                    changeHundreds++;
                    temp--;
                    remainingAmount = originalAmount - 100;
                    originalAmount = remainingAmount;
                }
            }
            while ((originalAmount % 50) < originalAmount && temp > 0)
            {
                  temp = Fifties;
                if (originalAmount - 50 > 0)
                {
                    temp--;
                    changeFifties++;
                    remainingAmount = originalAmount - 50;
                    originalAmount = remainingAmount;
                }
            }
            while ((originalAmount % 20) < originalAmount && temp > 0)
            {
                temp = Twenties;
                if (originalAmount - 20 > 0)
                {
                    temp--;
                    changeTwenties++;
                    remainingAmount = originalAmount - 20;
                    originalAmount = remainingAmount;
                }
            }
            while ((originalAmount % 10) < originalAmount && temp > 0)
            {
                temp = Tens;
                if (originalAmount - 10 > 0)
                {
                    temp--;
                    changeTens++;
                    remainingAmount = originalAmount - 10;
                    originalAmount = remainingAmount;
                }

            }
            while ((originalAmount % 5) < originalAmount && temp > 0)
            {
                temp = Fives;
                if (originalAmount - 5 > 0)
                {
                    temp--;
                    changeFives++;
                    remainingAmount = originalAmount - 5;
                    originalAmount = remainingAmount;
                }
            }
            while ((originalAmount % 2) < originalAmount && temp > 0)
            {
                temp = Twos;
                if (originalAmount - 2 > 0)
                {
                    temp--;
                    changeTwos++;
                    remainingAmount = originalAmount - 2;
                    originalAmount = remainingAmount;
                }
            }
            while ((originalAmount % 1) < originalAmount && temp > 0)
            {
                temp = Ones;
                if (originalAmount - 1 > 0)
                {
                    temp--;
                    changeOnes++;
                    remainingAmount = originalAmount - 1;
                    originalAmount = remainingAmount;
                }
            }
            while ((originalAmount % 1) < originalAmount && temp > 0)
            {
                temp = Dollars;
                if (originalAmount - 1 > 0)
                {
                    temp--;
                    changeDollars++;
                    remainingAmount = originalAmount - 1;
                    originalAmount = remainingAmount;
                }
            }
            while ((originalAmount % 0.50) < originalAmount && temp > 0)
            {
                temp = HalfDollars;
                if (originalAmount - 0.50 > 0)
                {
                    temp--;
                    changeHalfDollars++;
                    remainingAmount = originalAmount - 0.50;
                    originalAmount = remainingAmount;
                }
            }
            while ((originalAmount % 0.25) < originalAmount && temp > 0)
            {
                temp = Quarters;
                if (originalAmount - 0.25 > 0)
                {
                    temp--;
                    changeQuarters++;
                    remainingAmount = originalAmount - 0.25;
                    originalAmount = remainingAmount;
                }
            }
            while ((originalAmount % 0.10) < originalAmount && temp > 0)
            {
                temp = Dimes;
                if (originalAmount - 0.10 > 0)
                {
                    temp--;
                    changeDimes++;
                    remainingAmount = originalAmount - 0.10;
                    originalAmount = remainingAmount;
                }
            }
            while ((originalAmount % 0.05) < originalAmount && temp > 0)
            {
                temp = Nickels;
                if (originalAmount - 0.05 > 0)
                {
                    temp--;
                    changeNickels++;
                    remainingAmount = originalAmount - 0.05;
                    originalAmount = remainingAmount;
                }
            }
            while ((originalAmount % 0.01) < originalAmount && temp > 0)
            {
                temp = Pennies;
                if (originalAmount - 0.01 > 0)
                {
                    temp--;
                    changePennies++;
                    remainingAmount = originalAmount - 0.01;
                    originalAmount = remainingAmount;
                }
            }
            OnPropertyChange("ChangeHundreds");
            OnPropertyChange("ChangeFifties");
            OnPropertyChange("ChangeTwenties");
            OnPropertyChange("ChangeTens");
            OnPropertyChange("ChangeFives");
            OnPropertyChange("ChangeTwos");
            OnPropertyChange("ChangeOnes");
            OnPropertyChange("ChangeDollarCoins");
            OnPropertyChange("ChangeHalfDollars");
            OnPropertyChange("ChangeQuarters");
            OnPropertyChange("ChangeDimes");
            OnPropertyChange("ChangeNickles");
            OnPropertyChange("ChangePennies");
        }

        public void FinalizeSale()
        {
            Hundreds += PaymentHundreds;
            Hundreds -= ChangeHundreds;
            paymentHundreds = 0;

            Fifties += PaymentFifties;
            Fifties -= ChangeFifties;
            paymentFifties = 0;

            Twenties += PaymentTwenties;
            Twenties -= ChangeTwenties;
            paymentTwenties = 0;

            Tens += PaymentTens;
            Tens -= ChangeTens;
            paymentTens = 0;

            Fives += PaymentFives;
            Fives -= ChangeFives;
            paymentFives = 0;

            Twos += PaymentTwos;
            Twos -= ChangeTwos;
            paymentTwos = 0;

            Ones += PaymentOnes;
            Ones -= ChangeOnes;
            paymentOnes = 0;

            Dollars += PaymentDollars;
            Dollars -= ChangeDollars;
            paymentDollars = 0;

            HalfDollars += PaymentHalfDollars;
            HalfDollars -= ChangeHalfDolllars;
            paymentHalfDollars = 0;

            Quarters += PaymentQuarters;
            Quarters -= ChangeQuarters;
            paymentQuarters = 0;

            Dimes += PaymentDimes;
            Dimes -= ChangeDimes;
            paymentDimes = 0;

            Nickels += PaymentNickels;
            Nickels -= ChangeNickels;
            paymentNickels = 0;

            Pennies += PaymentPennies;
            Pennies -= ChangePennies;
            paymentPennies = 0;

            ChangedOwedToCustomers();
            PrintReciept();
        }

        public void PrintReciept()
        {
            List<string> Order = new List<string>();
            Order.Add("Order: " + O.Number);

            foreach (IOrderItem item in O)
            {
                Order.Add(item.ToString() + ":");
                foreach(string instruction in item.SpecialInstructions)
                {
                    Order.Add(instruction);
                }
                Order.Add("Calories: " + item.Calories);
                Order.Add("Price: $" + String.Format("0:0.00",item.Price));
                Order.Add("");
            }
            Order.Add("Total Calories" + O.Calories);
            Order.Add("SubTotal: " + String.Format("0:0.00", O.Subtotal));
            Order.Add("Tax: " + String.Format("0:0.00", O.Tax));
            Order.Add("Total: " + String.Format("0:0.00", O.Total));

            foreach (string str in Order)
            {
                RecieptPrinter.PrintLine(str);
            }

            RecieptPrinter.CutTape();
        }
    }
}
