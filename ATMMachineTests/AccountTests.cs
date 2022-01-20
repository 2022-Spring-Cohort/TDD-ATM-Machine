using ATMMachine;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMMachineTests
{
    class AccountTests
    {
        private Account myAccount;

        [SetUp]
        public void Setup()
        {
            myAccount = new Account();
        }

        [Test]
        public void Balance_Should_Return_Account_Balance()
        {
            // Arrange

            // Act
            myAccount.Balance = 100.00;

            //Assert
            Assert.AreEqual(100.00, myAccount.Balance);
        }

        [Test]
        public void Balance_Should_Return_New_Balance_Of_200()
        {
            // Arrange
            
            // Act

            // Assert
            Assert.AreEqual(200.00, myAccount.Balance);
        }

        [Test]
        public void Withdraw_Should_Decrement_Balance()
        {
            // Arrange

            // Act
            myAccount.Withdraw(0.00);

            // Assert
            Assert.AreEqual(200.00, myAccount.Balance);
        }

        [Test]
        public void Deposit_Should_Add_100_To_Balance()
        {
            // Arrange

            // Act
            myAccount.Deposit();

            // Assert
            Assert.AreEqual(300.00, myAccount.Balance);
        }

        [Test]
        public void Withdraw_Should_Subtract_Specific_Amount_From_Balance()
        {
            // Arrange

            // Act
            myAccount.Withdraw(50.00);

            // Assert
            Assert.AreEqual(150.00, myAccount.Balance);
        }

        [Test]
        public void Account_Should_Default_To_Checking()
        {
            // Arrange
            // Act

            Assert.AreEqual(AccountType.Checking, myAccount.Type);
        }

        [Test]
        public void ChangeAccount_Should_Change_Type_To_Savings()
        {
            // Arrange
            // Act
            myAccount.ChangeAccount();

            Assert.AreEqual(AccountType.Savings, myAccount.Type);
        }
    }
}
