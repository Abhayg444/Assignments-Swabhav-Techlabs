namespace Reverse_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to reverse: ");
            int number = int.Parse(Console.ReadLine());
            ReverseNumber(number);
        }
        public static void ReverseNumber(int number)
        {
            int reversed = 0;
            while (number > 0)
            {
                int digit = number % 10;
                reversed = reversed * 10 + digit;
                number /= 10;
            }
            Console.WriteLine($"\nReversed Number: {reversed}");
        }
    }
}
