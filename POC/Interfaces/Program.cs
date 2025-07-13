namespace Interfaces
{
    interface IDrive
    {
        void Start();
    }

    interface IStop
    {
        void Stop();
    }

    public class Car : IDrive, IStop
    {
        public void Start()
        {
            Console.WriteLine("Car started.......");
        }

        public void Stop()
        {
            Console.WriteLine("Car stopped........");
        }
    }

    internal class Program
    {
        public static void Main()
        {
            Car car = new Car();
            car.Start();
            car.Stop();
        }
    }
}
