using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Chaining
{
    internal class Student
    {
        public int Id;
        public string Name;
        public string Course;
        public int Age;

        public Student(int id, string name, string course, int age)
        {
            Id = id;
            Name = name;
            Course = course;
            Age = age;
        }

        public Student(int id, string name, string course)
        {
            Id = id;
            Name = name;
            Course = course;
            Age = 18;

        }

        public Student(int id, string name) 
        {
            Id = id;
            Name = name;
            Course = "Default Course";
            Age = 18;
        }

        public void Display()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Course: {Course}, Age: {Age}");
        }
    }
}
