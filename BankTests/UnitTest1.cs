using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankTests
{
    [TestClass]
    public class UnitTest1
    {
        BankAccount bankAccount;
        int id;

        [TestInitialize]
        public void Initialize()
        {
            id = 1234;
            bankAccount = new BankAccount(id);
        }

        [TestMethod]
        public void TestID()
        {
            // arrange

            // act
            var balanceId = bankAccount.ID;

            // asssert
            Assert.AreEqual(id, balanceId);
        }

        [TestMethod]
        public void TestBalance()
        {
            // arrange

            // act
            var balance = bankAccount.Balance;

            // assert
            Assert.AreEqual(0, balance);
        }

        [TestMethod]
        public void TestDeposit()
        {
            // arrange
            var amount = 40.50;

            // act
            bankAccount.Deposit(amount);

            // assert
            Assert.AreEqual(amount, bankAccount.Balance);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestNegativeDeposit()
        {
            // arrange
            var amount = -40.99;

            // act
            bankAccount.Deposit(amount);

            // assert
            Assert.AreEqual(0, bankAccount.Balance);
        }

        [TestMethod]
        public void TestWithdraw()
        {
            // arrange
            var amount = 44.50;
            bankAccount.Deposit(100);

            // act
            bankAccount.Withdraw(amount);

            // assert
            Assert.AreEqual(55.50, bankAccount.Balance);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestWithdrawNegativeAmount()
        {
            // arrange
            var amount = -50;

            // act
            bankAccount.Withdraw(amount);

            // assert
            Assert.AreEqual(0, bankAccount.Balance);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestWithdrawTooMuch()
        {
            // arrange
            var amount = 145.99;
            bankAccount.Deposit(100);

            // act
            bankAccount.Withdraw(amount);

            // assert
            Assert.AreEqual(100, bankAccount.Balance);
        }
    }
}


