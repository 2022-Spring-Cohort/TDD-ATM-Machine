using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMMachine
{
    public class Account
    {
        public double Balance { get; set; }
        public AccountType Type { get; set; }

        public Account()
        {
            Type = AccountType.Checking;
            Balance = 200.00;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
            // Balance = Balance - 10;
        }

        //public void Withdraw(double amount)
        //{
        //    Balance -= amount;
        //}

        public void Deposit()
        {
            Balance += 100.00;
        }

        public void ChangeAccount()
        {
            Type = AccountType.Savings;
        }

    }

    public enum AccountType
    {
        Checking,
        Savings
    }
}
