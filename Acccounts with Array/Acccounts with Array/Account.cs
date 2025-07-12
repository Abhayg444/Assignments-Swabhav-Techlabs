using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Acccounts_with_Array
{
    enum AccountType
    {
        Savings,
        Current
    }
    internal class Account
    {
        public string accountNumber;
        private string accountHolderName;
        private double balance;
        private AccountType accountType;

        public Account(string accountNumber, string accountHolderName, double balance, AccountType accountType)
        {
            this.accountNumber = accountNumber;
            this.accountHolderName = accountHolderName;
            this.balance = balance;
            this.accountType = accountType;
        }
        public void GetBalance()
        {
            Console.WriteLine($"Your current balance is: {balance} RS");
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited: {amount} RS. \nNew Balance: {balance} RS");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public void Withdraw(double amount)
        {
            if((balance -=amount) < 500)
            {
                Console.WriteLine("Minimium Balance of 500 needs to be maintained..");
                return;
            }
            else if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn: {amount} RS. \nNew Balance: {balance} RS");
            }
            else if (amount > balance)
            {
                Console.WriteLine("Insufficient balance for this withdrawal.");
            }
            else
            {
                Console.WriteLine("Withdrawal amount must be positive.");
            }
        }
        

        public string ToString()
        {
            return $"Account Number: {accountNumber}\n" +
                   $"Account Holder Name: {accountHolderName}\n" +
                   $"Balance: {balance} RS\n" +
                   $"Account Type: {accountType}\n";
        }
    }
}
