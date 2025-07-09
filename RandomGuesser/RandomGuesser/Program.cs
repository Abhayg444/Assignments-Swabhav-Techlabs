using System;

namespace RandomGuesser
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int plygn = 1;
            do
            {
                Random rng = new Random();
                int RnNum = rng.Next(1, 101);
                int Count = 0;
                int Tries = 0;
                while (Count == 0)
                {
                    Tries++;
                    Console.WriteLine("Guess the Number? :");
                    Console.WriteLine(RnNum);
                    int Guessed = int.Parse(Console.ReadLine());
                    Count = Guesser(Guessed, RnNum, Count);
                }
                Console.WriteLine($"You won in {Tries} Tries");
                Console.WriteLine("Want to play again? \n 1.Yes\n 2.No ");
                plygn = int.Parse(Console.ReadLine());

            } while (plygn == 1);
            static int Guesser(int Number, int RnNum, int Counter)
            {
                int Tries = 0;
                if (Number == RnNum)
                {
                    Console.WriteLine("Yayy!!...You have guessed the Correct Number");
                    return 1;
                }
                else if (RnNum > Number)
                {
                    Console.WriteLine("Sorry too Low number");
                    return 0;
                }
                else if (RnNum < Number)
                {
                    Console.WriteLine("Sorry Too High Number");
                    return 0;
                }
                return 0;
            }
        }
    }
}