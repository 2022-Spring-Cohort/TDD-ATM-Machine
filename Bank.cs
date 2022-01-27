using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMMachine
{
    public class Bank
    {
        public List<Account> AccountList { get; set; }

        public Bank()
        {
            AccountList = new List<Account>();
        }

        public void Menu()
        {

            Console.WriteLine("ATM CODING EXAMPLE\n\n");

            // condition for your menu to continue
            bool isRunning = true;
            while (isRunning)
            {
                // a list of your instructions for your menu
                Console.WriteLine("Choose an option below:");
                Console.WriteLine("1. NEW ACCOUNT");
                Console.WriteLine("2. Check Balances");
                Console.WriteLine("3. Create Transaction");
                Console.WriteLine("4. Quit");

                // the user is selecting a menu option from above
                int choice = Convert.ToInt32(Console.ReadLine());

                // determining which methods to run based on the user input
                switch (choice)
                {
                    case 1:
                        // menu option 1
                        
                        break;
                    case 2:
                        break;
                    case 3:
                        // quit case, set the condition at the top to false
                        isRunning = false;
                        break;
                    case 4:
                    case 5:
                        // add instruction code here
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine("Good bye! Press any key to close the console window.");
            Console.ReadKey();
        }

        public void CreateAccount()
        {
            Console.WriteLine("Choose an account type below: ");
            Console.WriteLine("1. Checking");
            Console.WriteLine("2. Savings");

            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the account number: ");
            string accountNumber = Console.ReadLine();

            if (choice == 1)
            {

                AddAccount(new Checking() { AccountNumber = accountNumber });
            }
            else
            {
                AddAccount(new Savings() { AccountNumber = accountNumber });
            }
        }

        public void AddAccount(Account newAccount)
        {
            bool accountExists = false;
            foreach(Account account in AccountList)
            {
                if(account.AccountNumber == newAccount.AccountNumber)
                {
                    accountExists = true;
                }
            }

            if (!accountExists)
            {
                AccountList.Add(newAccount);
            }
            else
            {
                Console.WriteLine("That account already exists.");
            }
            
        }
    }
}
