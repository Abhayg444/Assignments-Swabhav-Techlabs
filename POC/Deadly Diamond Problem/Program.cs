namespace Deadly_Diamond_Problem
{
    interface IPerson
    {
        string Name { get; set; }
        void ShowDetails();
    }

    interface IStudent : IPerson
    {
        void Study();
    }

    interface ITeacher : IPerson
    {
        void Teach();
    }

    public class TeachingAssistant : IStudent, ITeacher
    {
        public string Name { get; set; }

        public TeachingAssistant(string name)
        {
            Name = name;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Name: {Name}, Role: Teaching Assistant");
        }

        public void Study()
        {
            Console.WriteLine($"{Name} is studying.");
        }

        public void Teach()
        {
            Console.WriteLine($"{Name} is teaching.");
        }
    }

    internal class Program
    {
        public static void Main()
        {
            TeachingAssistant ta = new TeachingAssistant("Amit");

            ta.ShowDetails();
            ta.Study();
            ta.Teach();

            IStudent studentRole = ta;
            studentRole.ShowDetails();
            studentRole.Study();

            ITeacher teacherRole = ta;
            teacherRole.ShowDetails();
            teacherRole.Teach();
        }
    }
}
