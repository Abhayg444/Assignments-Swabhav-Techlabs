namespace Single_Inheritance_POC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Abhay Gupta", 20, "S12345", "Computer Science");
            student.ShowStudentDetails();
        }
    }
}
