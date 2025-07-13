using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Inheritance_POC
{
    internal class Person
    {
        public string Name;
        public int Age;

        public void ShowPersonDetails()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }
    }
}
