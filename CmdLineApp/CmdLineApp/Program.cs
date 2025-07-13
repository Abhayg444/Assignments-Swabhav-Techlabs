namespace CmdLineApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = args.Select(int.Parse).ToArray();

            int count = numbers.Length;
            int sum = numbers.Sum();
            double average = numbers.Average();
            int max = numbers.Max();
            int min = numbers.Min();

            Console.WriteLine($"Count: {count}");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average:F2}");
            Console.WriteLine($"Maximum: {max}");
            Console.WriteLine($"Minimum: {min}");
        }

    }
}
