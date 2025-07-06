namespace BankGame_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rounds = 1;
            string operation;
            BankAccount bankAccount1 = new BankAccount("Alice", rnd.Next(5000, 100001));
            BankAccount bankAccount2 = new BankAccount("Bob", rnd.Next(5000, 100001));
            Console.WriteLine("--------------Bank Game App---------------\n");
            //To check the logic is correct, uncomment the lines below

            //Console.WriteLine($"Account1: {bankAccount1.AccountHolder} with initial balance: {bankAccount1.GetBalance()}");
            //Console.WriteLine($"Account2: {bankAccount2.AccountHolder} with initial balance: {bankAccount2.GetBalance()}\n");
            while (rounds < 4)
            {
                Console.WriteLine($"Round {rounds}");
                Console.Write("Account1 Withdraw or Deposit (w/d):");
            again:
                operation = Console.ReadLine()?.ToLower();
                switch (operation)
                {
                    case "w":
                        Console.Write("Enter amount to withdraw:");
                        if (double.TryParse(Console.ReadLine(), out double withdrawAmount1))
                        {
                            bankAccount1.Withdraw(withdrawAmount1);
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount.");
                        }
                        break;
                    case "d":
                        Console.Write("Enter amount to deposit:");
                        if (double.TryParse(Console.ReadLine(), out double depositAmount1))
                        {
                            bankAccount1.Deposit(depositAmount1);
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operation. Please enter 'w' for withdraw or 'd' for deposit.");
                        goto again;
                }

                Console.Write("Account2 Withdraw or Deposit (w/d):");
            again2:
                operation = Console.ReadLine()?.ToLower();
                switch (operation)
                {
                    case "w":
                        Console.Write("Enter amount to withdraw:");
                        if (double.TryParse(Console.ReadLine(), out double withdrawAmount2))
                        {
                            bankAccount2.Withdraw(withdrawAmount2);
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount.");
                        }
                        break;
                    case "d":
                        Console.Write("Enter amount to deposit:");
                        if (double.TryParse(Console.ReadLine(), out double depositAmount2))
                        {
                            bankAccount2.Deposit(depositAmount2);
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operation. Please enter 'w' for withdraw or 'd' for deposit.");
                        goto again2;
                }
                rounds++;
            }
            if (bankAccount1.GetBalance() > bankAccount2.GetBalance())
            {
                Console.WriteLine($"\nWinner is {bankAccount1.AccountHolder} with balance: {bankAccount1.GetBalance()}");
            }
            else if (bankAccount1.GetBalance() < bankAccount2.GetBalance())
            {
                Console.WriteLine($"\nWinner is {bankAccount2.AccountHolder} with balance: {bankAccount2.GetBalance()}");
            }
            else
            {
                Console.WriteLine("It's a tie!");

            }
        }
    }
}
