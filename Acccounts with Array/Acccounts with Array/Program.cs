using System;

namespace Acccounts_with_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------IDBI BANK--------------\n");
            bool continueBanking = true;
            Account[] accounts = new Account[100];
            Account account = null;
            int accountCount = 0;
            Random random = new Random();
            while (continueBanking)
            {
                Console.WriteLine("\nBanking Operations\n" +
                    "1. Create Account\n" +
                    "2. Deposit\n" +
                    "3. Withdraw\n" +
                    "4. Check Balance\n" +
                    "5. Exit\n");

                Console.Write("Select an option: ");
                int option= int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        long randomNumber = random.Next(1000000, 9999999);
                        string accountNumber = "IDBI1000" + randomNumber;
                        Console.Write("Enter Account Holder Name: ");
                        string accountHolderName = Console.ReadLine();
                        Console.Write("Enter Initial Balance: ");
                        double initialBalance = double.Parse(Console.ReadLine());
                        Console.Write("Enter Account Type (0.Savings/1.Current): ");
                        string accountTypeInput = Console.ReadLine();
                        AccountType accountType = (AccountType)Enum.Parse(typeof(AccountType), accountTypeInput, true);

                        accounts[accountCount] = new Account(accountNumber,accountHolderName, initialBalance, accountType);
                        Console.WriteLine("Account created successfully!");
                        Console.WriteLine(accounts[accountCount].ToString());
                        accountCount++;
                        break;
                    case 2:
                        Console.Write("Enter Account Number to Deposit: ");
                        string accountNo = Console.ReadLine().ToUpper();
                        foreach (Account acc in accounts)
                        {
                            if (acc.accountNumber == accountNo)
                            {
                                account = acc;
                                Console.Write("Enter Amount to Deposit: ");
                                double depositAmount = double.Parse(Console.ReadLine());
                                account.Deposit(depositAmount);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Account not found. Please check the account number.");
                                break;
                            }
                        }
                            break;

                    case 3:
                        Console.Write("Enter Account Number to Withdraw: ");
                        accountNo = Console.ReadLine().ToUpper();
                        foreach (Account acc in accounts)
                        {
                            if (acc.accountNumber == accountNo)
                            {
                                account = acc;
                                Console.Write("Enter Amount to Withdraw: ");
                                double withdrawAmount = double.Parse(Console.ReadLine());
                                account.Withdraw(withdrawAmount);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Account not found. Please check the account number.");
                                break;
                            }
                        }
                        break;

                    case 4:
                        Console.Write("Enter Account Number to show Balance: ");
                        accountNo = Console.ReadLine().ToUpper();
                        foreach (Account acc in accounts)
                        {
                            if (acc.accountNumber == accountNo)
                            {
                                account = acc;
                                account.GetBalance();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Account not found. Please check the account number.");
                                break;
                            }
                        }
                        break;

                    case 5:
                        continueBanking = false;
                        Console.WriteLine("Thank you for banking with us!");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
                
            }


        }
    }
}
