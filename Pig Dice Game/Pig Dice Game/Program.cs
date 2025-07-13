namespace Pig_Dice_Game
{
    internal class Program
    {
            static void Main(string[] args)
            {
                Random rand = new Random();
                int totalScore = 0;
                int turnCount = 0;

                Console.WriteLine("Let's Play PIG!");
                Console.WriteLine("Reach 20 points by rolling the dice.\n");

                while (totalScore < 20)
                {
                    turnCount++;
                    int turnScore = 0;
                    Console.WriteLine("TURN " + turnCount);

                    bool turnOver = false;
                    while (!turnOver)
                    {
                        Console.Write("Roll or hold? (r/h): ");
                        string choice = Console.ReadLine().ToLower();

                        if (choice == "r")
                        {
                            int die = rand.Next(1, 7);
                            Console.WriteLine("Die: " + die);

                            if (die == 1)
                            {
                                Console.WriteLine("Turn over. No score.");
                                turnScore = 0;
                                turnOver = true;
                            }
                            else
                            {
                                turnScore = turnScore + die;
                            }
                        }
                        else if (choice == "h")
                        {
                            totalScore = totalScore + turnScore;
                            Console.WriteLine("Score for turn: " + turnScore);
                            Console.WriteLine("Total score: " + totalScore);
                            Console.WriteLine();
                            turnOver = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Enter 'r' or 'h'.");
                        }
                    }
                }

                Console.WriteLine("You finished in " + turnCount + " turns!");
                Console.WriteLine("Game over!");
            }
        
    }

}

