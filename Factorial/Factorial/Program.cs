namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number to calculate its factorial:");
            int number = int.Parse(Console.ReadLine());
            Factorial(number);
        }

        public static void Factorial(int number)
        {
            if (number < 0)
            {
                Console.WriteLine("Factorial is not defined for negative numbers.");
            }
            else if (number == 0 || number == 1)
            {
                Console.WriteLine("Factorial of " + number + " is 1.");
            }
            else
            {
                long result = 1;
                for (int i = 2; i <= number; i++)
                {
                    result *= i;
                }
                Console.WriteLine("Factorial of " + number + " is " + result + ".");
            }
        }
    }
}
