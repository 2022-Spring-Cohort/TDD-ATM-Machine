using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMMachine
{
    public class Account
    {
        public const string ROUTING_NUMBER = "33055 66885 258";
        public string AccountNumber { get; set; }
        public double Balance { get; set; }
        public string PIN { get; set; }
        private List<Transaction> Transactions { get; set; }

        public Account()
        {
            Transactions = new List<Transaction>();
            Balance = 200.00;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public void AddTransaction(string to, string from, double amount, double fee, string origin)
        {
            
            Transaction newTransaction = new Transaction(to, from, amount, fee, origin);
            Transactions.Add(newTransaction);
            
        }

        public virtual void Deposit()
        {
            Balance += 100.00;
        }

        public void PrintBalance()
        {
            Console.Clear();
            Console.WriteLine("The balance of your account is: " + this.Balance);

            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
        }


    }

}
