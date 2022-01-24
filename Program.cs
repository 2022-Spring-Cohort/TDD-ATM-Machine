using System;
using System.Collections.Generic;

namespace ATMMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Checking myChecking = new Checking();
            Savings mySavings = new Savings();

            Console.WriteLine("ATM Machine Coding Example\n\n");

            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Choose an option below:");
                Console.WriteLine("1. Checking");
                Console.WriteLine("2. Savings");
                Console.WriteLine("3. Quit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        myChecking.DisplayMenu();
                        break;
                    case 2:
                        break;
                    case 3:
                        isRunning = false;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine("Good bye! Press any key to close the application.");
            Console.ReadKey();

        }
    }
}
