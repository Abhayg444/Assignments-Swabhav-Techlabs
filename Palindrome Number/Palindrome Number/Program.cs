namespace Palindrome_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to check if it is a palindrome:");
            int number = int.Parse(Console.ReadLine());
            Palindrome(number);

        }
        static void Palindrome(int number)
        {
            if (number < 0)
            {
                Console.WriteLine("Negative numbers cannot be palindromes.");
            }
            int originalNumber = number;
            int reversedNumber = 0;
            while (number > 0)
            {
                int digit = number % 10;
                reversedNumber = reversedNumber * 10 + digit;
                number /= 10;
            }
            if( originalNumber == reversedNumber)
            {
                Console.WriteLine($"{originalNumber} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{originalNumber} is not a palindrome.");
            }

        }
    }
}
