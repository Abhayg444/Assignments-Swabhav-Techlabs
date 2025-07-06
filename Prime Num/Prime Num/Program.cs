using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Prime_Num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());
            if (IsPrime(num))
                Console.WriteLine($"{num} is a Prime Number.");
            else
                Console.WriteLine($"{num} is NOT a Prime Number.");

        }

        public static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            if (number == 2)
                return true;
            if (number % 2 == 0)
                return false;
            for (int i = 3; i * i <= number; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
