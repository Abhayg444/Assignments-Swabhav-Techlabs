namespace BMI_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int continueProgram = 1;
            while (continueProgram==1)
            {
                Console.WriteLine("Welcome to the BMI Calculator!");
                Console.WriteLine(" 1. Custom Height & Weight \n 2. Default Height & Weight");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter your ID:");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter your Name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter your Age:");
                        int age = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter your Height (in meter):");
                        double height = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter your Weight (in kilograms):");
                        double weight = double.Parse(Console.ReadLine());
                        Person person1 = new Person(id, age, name, height, weight);
                        Console.WriteLine($"Your BMI is: {person1.CalculateBMI()}");
                        Console.WriteLine($"Your Body Type is: {person1.GetBodyType()}");

                        Console.WriteLine("Do you want to continue? (1.yes / 2.no)");
                        continueProgram = int.Parse(Console.ReadLine());

                        break;

                    case 2:
                        Console.WriteLine("Enter your ID:");
                        id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter your Name:");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter your Age:");
                        age = int.Parse(Console.ReadLine());
                        Person person2 = new Person(id, name, age);
                        Console.WriteLine($"Your BMI is: {person2.CalculateBMI()}");
                        Console.WriteLine($"Your Body Type is: {person2.GetBodyType()}");

                        Console.WriteLine("Do you want to continue? (1.yes / 2.no)");
                        continueProgram = int.Parse(Console.ReadLine());

                        break;

                        default:
                        Console.WriteLine("Invalid choice. Please select 1 or 2.");
                        continueProgram = 1; 
                        break;
                }
            
            }
        }
    }
}
