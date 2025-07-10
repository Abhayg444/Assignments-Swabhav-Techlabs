namespace Amstrong_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Amstrong Number Check");
            Console.Write("Enter a number to check if it is an Amstrong number:");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int amg = 0;
            while (num > 0)
            {
                int rem = num % 10;
                amg = amg + (rem * rem * rem);
                num = num / 10;
            }
            if (amg == temp)
            {
                Console.WriteLine("It is an Amstrong Number");
            }
            else
            {
                Console.WriteLine("It is not an Amstrong Number");
            }
        }
    }
}
