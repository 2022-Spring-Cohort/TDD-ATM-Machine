using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMMachine
{
    class Checking : Account
    {
        public int CheckNo { get; set; }
        public Checking()
        {
            this.Balance = 150.00;
            this.CheckNo = 120;
        }

        public override void Deposit()
        {
            //base.Deposit();
            Console.WriteLine("How much are you depositing?");
            double amount = Convert.ToDouble(Console.ReadLine());
            this.Balance += amount;
        }

        public void DisplayMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("Choose from the following:");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Print Balance");
                Console.WriteLine("4. Return to Account Screen");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        this.Deposit();
                        break;
                    case 2:
                        break;
                    case 3:
                        this.PrintBalance();
                        break;
                    case 4:
                        isRunning = false;
                        break;
                }
            }
            


        }
    }
}
