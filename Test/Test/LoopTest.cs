using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class LoopTest
    {
        public static void Main(string[] args)
        {
            string name = "Abhay";
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
            Console.WriteLine();

            while(name.Length > 0)
            {
                Console.WriteLine(name[0]);
                name = name.Substring(1);
            }
        }
    }
}
