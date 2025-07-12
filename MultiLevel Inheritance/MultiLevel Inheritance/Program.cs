namespace MultiLevel_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager
            {
                Name = "Abhay",
                Age = 21,
                EmployeeId = 73452,
                Department = "Auropay",
                ProjectName = "BuzzWizz"
            };
            manager.DisplayManagerInfo();
        }
    }
}
