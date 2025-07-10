namespace Palindrome_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string to check if it is a palindrome: ");
            string input = Console.ReadLine();
            Palindrome_String(input);
        }
        static void Palindrome_String(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("Input cannot be null or empty.");
                return;
            }
            string input = new string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
            string reversed = new string(input.Reverse().ToArray());
            if (input == reversed)
            {
                Console.WriteLine($"\n{str} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"\n{str} is not a palindrome.");
            }
        }
    }
}
