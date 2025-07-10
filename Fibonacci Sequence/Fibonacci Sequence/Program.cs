namespace Fibonacci_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 =0; int num2 =1;
            Console.Write("Fibonacci Sequence upto 8 numbers: ");
            for (int i = 0; i < 8; i++)
            {
                Console.Write($"{num1} ");
                int nextNum = num1 + num2;
                num1 = num2;
                num2 = nextNum;
            }

        }
    }
}
