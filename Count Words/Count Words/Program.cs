namespace Count_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Count Words in a Sentence");
            Console.Write("Enter the Sentence: ");
            string input = Console.ReadLine();

            string[] Words = input.Split(" ").ToArray();
            Console.WriteLine($"Number of Words: {Words.Length}");
        }
    }
}
