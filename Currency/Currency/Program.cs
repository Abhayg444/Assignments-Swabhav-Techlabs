namespace Currency
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your Currency: ");
            int amount = int.Parse(Console.ReadLine());
            Deno(amount);
        }

        static void Deno(int amount)
        {
            if (amount > 50000)
            {
                Console.WriteLine("Amount Exceeding");
            }
            else
            {
                int notesOf2000 = amount / 2000;
                int remainingAfter2000 = amount % 2000;

                int notesOf500 = remainingAfter2000 / 500;
                int remainingAfter500 = remainingAfter2000 % 500;

                int notesOf200 = remainingAfter500 / 200;
                int remainingAfter200 = remainingAfter500 % 200;

                int notesOf100 = remainingAfter200 / 100;

                Console.WriteLine("Two Thousand: {0}, Five Hundred: {1}, Two Hundred: {2}, Hundred: {3}", notesOf2000, notesOf500, notesOf200, notesOf100);
            }
        }
    }
}
