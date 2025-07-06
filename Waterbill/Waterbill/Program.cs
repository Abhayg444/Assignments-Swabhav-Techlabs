using System.Numerics;

namespace Waterbill
{
    public class Program
    {
        public static void Main(string[] args)
        { 
            Console.WriteLine("Enter units Consumed: ");
            int Num_Units = int.Parse(Console.ReadLine());
            Biller(Num_Units);
        }
        static void Biller(int Num_Units)
        {
            const int Meter_Charge = 75;
            const int NotGrt100 = 5;
            const int NotGrt250 = 10;
            int charge;
            if (Num_Units <= 100)
            {
                charge = Num_Units * NotGrt100;
                Console.WriteLine("Your total bill is: " + (charge + Meter_Charge));
            }
            else if (Num_Units <= 250)
            {
                charge = Num_Units * NotGrt250;
                Console.WriteLine("Your total bill is: " + (charge + Meter_Charge));
            }
            else
            {
                charge = Num_Units * 20;
                Console.WriteLine("Your total bill is: " + (charge + Meter_Charge));
            }
        }
    }
}
