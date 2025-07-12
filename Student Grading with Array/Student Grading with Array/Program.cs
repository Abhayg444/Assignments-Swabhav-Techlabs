namespace Student_Grading_with_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------STUDENT GRADING SYSTEM-----------");
            Console.WriteLine("Enter the number of students:");
            int numOfStudents = int.Parse(Console.ReadLine());
            Student[] students = new Student[numOfStudents];
            int seats = 0;
            while (numOfStudents > 0)
            {
                Console.WriteLine("Enter Student Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Roll Number:");
                int roll = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Marks for 5 Subjects (English, Maths, Science, Social Science, Marathi):");
                int[] marksArray = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    marksArray[i] = int.Parse(Console.ReadLine());
                }
                students[seats] = new Student(name, roll, marksArray);
                seats++;
                numOfStudents--;
            }

            /*Student student1 = new Student("Jatin Pandey", 1, new int[] { 85, 90, 78, 88, 92 });
            Student student2 = new Student("Jasmine Shaikh", 2, new int[] { 75, 80, 70, 65, 60 });
            Student student3 = new Student("Rohan Verma", 3, new int[] { 95, 88, 92, 85, 90 });
            Student student4 = new Student("Aisha Khan", 4, new int[] { 60, 70, 65, 75, 80 });

            student1.printReport(student1);
            student2.printReport(student2);
            student3.printReport(student3);
            student4.printReport(student4);*/

            foreach (var student in students)
            {
                student.printReport(student);
                Console.WriteLine("");
            }
        }
    }
}
