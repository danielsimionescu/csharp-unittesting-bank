using BankTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankAccount = new BankAccount(9032321);

            bankAccount.Deposit(40);

            Console.WriteLine(bankAccount.Balance);

            try
            {
                bankAccount.Withdraw(100);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(bankAccount.Balance);

            Console.ReadKey();
            Console.WriteLine("Press any key to stop...");
        }
    }
}
