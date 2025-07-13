using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC
{
    internal class Dog: Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }
}
