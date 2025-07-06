using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator
{
    internal class Person
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public double Height { get; set; } // in meters
        public double Weight { get; set; } // in kilograms
        public Person(int id, int age, string name, double height, double weight)
        {
            Id = id;
            Age = age;
            Name = name;
            Height = height;
            Weight = weight;
        }

        public Person(int id, string name ,int age)
        {
            Id= id;
            Name = name;
            Age = age;
            Height = 5; 
            Weight = 50; 
        }
        public double CalculateBMI()
        {
            return Weight / (Height * Height);
        }
        public string GetBodyType()
        {
            double bmi = CalculateBMI();
            if (bmi < 18.5)
                return "Underweight";
            else if (bmi < 24.9)
                return "Normal weight";
            else if (bmi < 29.9)
                return "Overweight";
            else
                return "Obesity";
        }
    }
}
