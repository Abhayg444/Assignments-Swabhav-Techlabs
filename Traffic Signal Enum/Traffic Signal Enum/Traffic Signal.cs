using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic_Signal_Enum
{
    enum Traffic_Signal_Info
    {
        Red,
        Yellow,
        Green
    }
   
    internal class Traffic_Signal
    {
        public void signalInfo(int signal)
        {
            switch (signal)
            {
                case 1:
                    Console.WriteLine($"Signal: {Traffic_Signal_Info.Red}-->Stop");
                    break;
                case 2:
                    Console.WriteLine($"Signal: {Traffic_Signal_Info.Yellow}-->Get Ready");
                    break;
                case 3:
                    Console.WriteLine($"Signal:  {Traffic_Signal_Info.Green}-->Go");
                    break;
                default:
                    Console.WriteLine("Invalid Signal");
                    break;
            }
        }
    }
}
