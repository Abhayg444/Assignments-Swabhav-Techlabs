namespace Constructor_Chaining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Boxing Unboxing Example  
            int num = 123456;
            object boxedNum = num;

            Console.WriteLine($"Boxed Value: {boxedNum}");

            int unboxedNum = (int)boxedNum;
            Console.WriteLine($"Unboxed Value: {unboxedNum}\n\n");

            // Constructor Chaining Example

            Student student1 = new Student(1, "Alice", "Mathematics", 20);
            Student student2 = new Student(2, "Bob", "Physics");
            Student student3 = new Student(3, "Charlie");

            student1.Display();
            student2.Display();
            student3.Display();
        }
    }
}
