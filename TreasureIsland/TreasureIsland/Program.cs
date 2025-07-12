namespace TreasureIsland
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Treasure Island\n Your mission is to find the Treasure");
            TreasureMap();
        }
        static void TreasureMap()
        {
            Console.WriteLine("1.Left or 2.Right?");
            int step1 = int.Parse(Console.ReadLine());
            int step2 = 0;
            int step3 = 0;
            switch (step1)
            {
                case 1:
                    Console.WriteLine("You took Left");
                    Console.WriteLine("1.Swim or 2.Wait?");
                    step2 = int.Parse(Console.ReadLine());
                    switch (step2)
                    {

                        case 2:
                            Console.WriteLine("You chose to wait..");
                            Console.WriteLine("Which Door?\n 1.Red 2.Yellow 3.Blue");
                            step3 = int.Parse(Console.ReadLine());
                            switch (step3)
                            {
                                case 1:
                                    Console.WriteLine("Burned by Fire..\n Game Over");
                                    break;

                                case 2:
                                    Console.WriteLine("You Win..!!");
                                    break;

                                case 3:
                                    Console.WriteLine("Eaten by Beasts..\n Game Over");
                                    break;
                                default:
                                    Console.WriteLine("Game Over");
                                    break;
                            }
                            break;
                        default:
                            Console.WriteLine("Attacked by Trout\n Game Over");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Fall into the Hole \n Game Over");
                    break;
            }
        }
    }
}