using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grading_with_Array
{
    internal class Student
    {
        public string studentName;
        public int rollNumber;
        public int[] marks = new int[5];

        public Student(string name, int roll, int[] marksArray)
        {
            studentName = name;
            rollNumber = roll;
            marks = marksArray;
        }

        public double CalculateAverage(Student student)
        {
            return student.marks.Average();
        }

        public string calculateGrade(double marks)
        {
            if (marks >= 90)
            {
                return "A+";
            }
            else if (marks >= 80)
            {
                return "A";
            }
            else if (marks >= 70)
            {
                return "B";
            }
            else if (marks >= 60)
            {
                return "C";
            }
            else if (marks >= 50)
            {
                return "D";
            }
            else
            {
                return "Fail";
            }
        }

        public void printReport(Student student)
        {
            Console.WriteLine("Student Name: " + student.studentName);
            Console.WriteLine("Roll Number: " + student.rollNumber);
            Console.WriteLine($"Marks : English: {marks[0]}, Maths: {marks[1]}, Science: {marks[2]}, Social Science: {marks[3]}, Marathi: {marks[4]}");
            double average = CalculateAverage(student);
            Console.WriteLine("Average Marks: " + average);
            Console.WriteLine("Grade: " + calculateGrade(average));
        }
    }
}
