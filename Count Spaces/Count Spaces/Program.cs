namespace Count_Spaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write the sentence: ");
            string sentence = Console.ReadLine();
            string[] strings = sentence.Split(" ").ToArray();
            int spaceCount = strings.Length-1;

            Console.WriteLine($"\nNumber of spaces in the sentence : {spaceCount}");
        }
    }
}
