using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Inheritance_POC
{
    internal class Student: Person
    {
        public string StudentID;
        public string Course;
        
        public Student(string name, int age, string studentID, string course)
        {
            Name = name;
            Age = age;
            StudentID = studentID;
            Course = course;
        }

        public void ShowStudentDetails()
        {
            ShowPersonDetails();
            Console.WriteLine("Student ID: " + StudentID);
            Console.WriteLine("Course: " + Course);
        }
    }
}
