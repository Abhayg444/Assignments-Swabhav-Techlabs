using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevel_Inheritance
{
    internal class Employee : Person
    {
        public int EmployeeId;
        public string Department;

        public void DisplayEmployeeInfo()
        {
            DisplayPersonInfo();
            Console.WriteLine($"Employee ID: {EmployeeId}, Department: {Department}");
        }
    }
}
