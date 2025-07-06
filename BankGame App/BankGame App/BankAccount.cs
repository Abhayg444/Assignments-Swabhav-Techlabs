using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankGame_App
{
    internal class BankAccount
    {
        public string AccountHolder { get; set; }
        public double Balance { get; private set; }

        public BankAccount(string accountHolder, double initialBalance)
        {
            AccountHolder = accountHolder;
            Balance = initialBalance;
        }
        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
            }
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds for withdrawal.");
            }
            Balance -= amount;
        }
        public double GetBalance() { return Balance; }
    }
}
