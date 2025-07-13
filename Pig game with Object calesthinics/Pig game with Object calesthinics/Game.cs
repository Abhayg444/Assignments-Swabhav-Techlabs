using System;

namespace Pig_game_with_Object_calesthinics
{
    public class Game
    {
        private readonly Score totalScore = new Score();
        private readonly TurnCounter turns = new TurnCounter();
        public void Start()
        {
            PrintWelcome();
            while (!totalScore.HasReached(20))
            {
                PlayTurn();
            }
            PrintGameOver();
        }
        private void PrintWelcome()
        {
            Console.WriteLine("Let's Play PIG!");
            Console.WriteLine("Reach 20 points by rolling the dice.\n");
        }
        private void PlayTurn()
        {
            turns.Increment();
            Turn turn = new Turn();
            Console.WriteLine("TURN " + turns.Count());
            int scoreToAdd = turn.Play();
            totalScore.Add(scoreToAdd);
            Console.WriteLine("Total score: " + totalScore.Value());
            Console.WriteLine();
        }
        private void PrintGameOver()
        {
            Console.WriteLine("You finished in " + turns.Count() + " turns!");
            Console.WriteLine("Game over!");
        }
    }
    public class Turn
    {
        private readonly Die die = new Die();

        public int Play()
        {
            while (true)
            {
                string choice = AskChoice();
                if (choice == "r")
                {
                    int result = die.Roll();
                    Console.WriteLine("Die: " + result);
                    if (result == 1)
                    {
                        Console.WriteLine("Rolled a 1 — no points this turn.");
                        return 0;
                    }
                    string subChoice = AskRollOrHold(result);
                    if (subChoice == "h")
                    {
                        Console.WriteLine("Added " + result + " to total score.");
                        return result;
                    }
                }
                else
                {
                    Console.WriteLine("You must roll first before holding.");
                }
            }
        }
         private string AskChoice()
        {
            Console.Write("Roll or hold? (r/h): ");
            string input = Console.ReadLine().ToLower();
            if (input != "r" && input != "h") return AskChoice();
            return input;
        }

        private string AskRollOrHold(int lastRoll)
        {
            Console.Write("Hold to add " + lastRoll + " to total score? (h to hold, r to roll again): ");
            string input = Console.ReadLine().ToLower();
            if (input != "r" && input != "h") return AskRollOrHold(lastRoll);
            return input;
        }
    }
    public class Die
    {
        private readonly Random random = new Random();
        public int Roll()
        {
            return random.Next(1, 7);
        }
    }
    public class Score
    {
        private int value = 0;
        public void Add(int points)
        {
            value += points;
        }
        public int Value()
        {
            return value;
        }
        public bool HasReached(int target)
        {
            return value >= target;
        }
    }
    public class TurnCounter
    {
        private int turns = 0;
        public void Increment()
        {
            turns++;
        }
        public int Count()
        {
            return turns;
        }
    }
}
