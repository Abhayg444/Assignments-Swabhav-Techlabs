namespace Day_of_the_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Days of the Week Enum (1-7 ): ");
            DaySchedule daySchedule = new DaySchedule();
            int dayNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"Day is: {daySchedule.Schedule(dayNumber)}");

        }
    }
}
