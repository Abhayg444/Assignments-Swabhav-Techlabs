namespace String_Manipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write the String by Developer,Company,Location: ");
            string details = Console.ReadLine();

            string[] strings = details.Split(",").ToArray();
            Console.WriteLine($"\nDeveloper Name is {strings[0]}");
            Console.WriteLine($"Company Name is {strings[1]}");
            Console.WriteLine($"Location is {strings[2]}");

        }
    }
}
