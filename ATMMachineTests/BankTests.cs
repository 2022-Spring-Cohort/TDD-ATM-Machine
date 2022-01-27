using ATMMachine;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMMachineTests
{
    class BankTests
    {
        private Bank myBank;
        [SetUp]
        public void Setup()
        {
            myBank = new Bank();
        }

        [Test]
        public void Bank_Should_Have_List_Of_Accounts()
        {
            // Arrange

            // Act

            // Assert
            Assert.Zero(myBank.AccountList.Count);
        }

        [Test]
        public void AddAccount_Should_Increase_AccountList_By_One()
        {
            // Arrange

            // Act
            myBank.AddAccount(new Checking() { AccountNumber = "157098" });
            myBank.AddAccount(new Savings() { AccountNumber = "890751" });

            // Assert
            Assert.AreEqual(2, myBank.AccountList.Count);
        }

        [Test]
        public void AddAccount_Should_Prevent_Duplicate_Accounts()
        {
            // Arrange

            // Act
            myBank.AddAccount(new Checking() { AccountNumber = "1234" });
            myBank.AddAccount(new Checking() { AccountNumber = "1234" });

            // Assert
            Assert.AreEqual(1, myBank.AccountList.Count);
            Assert.AreNotEqual(2, myBank.AccountList.Count);
        }

        [Test]
        public void CreateAccount_Should_Add_An_Account_To_AccountList()
        {
            // Arrange

            // Act
            myBank.CreateAccount();

            // Assert
            Assert.AreEqual(1, myBank.AccountList.Count);
        }
    }
}
