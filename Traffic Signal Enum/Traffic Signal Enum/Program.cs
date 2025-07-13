namespace Traffic_Signal_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Traffic Light \n 1.Red \n 2.Yellow\n 3.Green  :");
            int signal= int.Parse(Console.ReadLine());
            Traffic_Signal trafficSignal = new Traffic_Signal();
            trafficSignal.signalInfo(signal);

        }
    }
}
