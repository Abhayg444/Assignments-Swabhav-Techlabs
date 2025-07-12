using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevel_Inheritance
{
    internal class Manager : Employee
    {
        public string ProjectName { get; set; }

        public void DisplayManagerInfo()
        {
            DisplayEmployeeInfo();
            Console.WriteLine($"Project Name: {ProjectName}");
        }
    }
}
