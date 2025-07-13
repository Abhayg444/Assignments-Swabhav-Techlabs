namespace ArrayTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];
            names[0] = "Abhay";
            names[1] = "Amit";
            names[2] = "Ankit";
            names[3] = "Anshul";
            names[4] = "Ankush";
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine();    
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
