namespace POC_on_ENUM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Know your schedule for the day \n 1.Monday 2.Tuesday 3.Wednesday 4.Thursday 5.Friday : ");
            int day = int.Parse(Console.ReadLine());
            Days_of_the_Week workday = new Days_of_the_Week();

            switch (day)
            {
                case 1:
                    Console.WriteLine(workday.Day(WorkingDaysofTheWeek.monday));
                    break;
                case 2:
                    Console.WriteLine(workday.Day(WorkingDaysofTheWeek.tuesday));
                    break;
                case 3:
                    Console.WriteLine(workday.Day(WorkingDaysofTheWeek.wednesday));
                    break;
                case 4:
                    Console.WriteLine(workday.Day(WorkingDaysofTheWeek.thursday));
                    break;
                case 5:
                    Console.WriteLine(workday.Day(WorkingDaysofTheWeek.friday));
                    break;
                default:
                    Console.WriteLine("Invalid day.");
                    break;
            }          
        }
    }
}
