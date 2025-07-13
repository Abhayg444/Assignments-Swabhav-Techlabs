namespace Movie_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MovieManager movieManager = new MovieManager();
            Console.WriteLine("--------------Welcome to the Movie App!-----------");
            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add Movie");
                Console.WriteLine("2. Display Movies");
                Console.WriteLine("3. Clear All Movies");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                
                string choice = Console.ReadLine();
                
                switch (choice)
                {
                    case "1":
                        Console.Write("Enter movie name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter movie ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Enter movie genre: ");
                        string genre = Console.ReadLine();
                        Console.Write("Enter movie year: ");
                        int year = int.Parse(Console.ReadLine());
                        
                        Movie newMovie = new Movie(name, id, genre, year);
                        movieManager.AddMovie(newMovie);
                        break;
                    case "2":
                        movieManager.DisplayMovie();
                        break;
                    case "3":
                        movieManager.ClearAllMovies();
                        break;
                    case "4":
                        movieManager.SaveToFile();
                        Console.WriteLine("Exiting the application.");

                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }
    }
}
