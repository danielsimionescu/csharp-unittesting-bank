using System;

namespace BankTests
{
    public class BankAccount
    {
        public int ID { get; private set; }
        public double Balance { get; private set; }

        public BankAccount(int id)
        {
            ID = id;
        }

        /// <summary>
        /// Deposit an amount of money in the account.
        /// </summary>
        /// <param name="amount"></param>
        public void Deposit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), amount, "The amount must be positive");
            }

            Balance += amount;
        }

        /// <summary>
        /// Withdraw an amount of money from the account.
        /// </summary>
        /// <param name="amount"></param>
        public void Withdraw(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), amount, "The amount must be positive");
            }
            if (amount > Balance)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), amount, "The amount is too much");
            }
            Balance -= amount;
        }
    }
}


