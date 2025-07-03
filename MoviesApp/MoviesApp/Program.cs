namespace MoviesApp
{
    internal class Program
    {
        static void DisplayMenu()
        {
            MovieManager movieManager = new MovieManager();
            bool flag = true;
            while (flag)
            {
                Console.Write(" 1.Add Movie\n 2.Display Movie\n 3.Display by Id\n 4.Remove Movie by ID\n 5.Remove All\n 6.Exit: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {

                            movieManager.AddMovie();
                        }
                        break;
                    case 2:
                        {
                            movieManager.DisplayAll();
                        }
                        break;
                    case 3:
                        {
                            movieManager.FindbyId();
                        }
                        break;
                    case 4:
                        {
                            movieManager.RemovebyID();
                        }
                        break;

                    case 5:
                        {
                            movieManager.RemoveAll();
                        }
                        break;

                    case 6:
                        {
                            flag = false;
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Wrong input!");
                        }
                        break;
                }
            }
        }
        static void LoadMoviesFromCsv(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("CSV file not found.");
                return;
            }

            List<Movie> movieListFromCsv = new List<Movie>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    bool isHeader = true;

                    while ((line = reader.ReadLine()) != null)
                    {
                        if (isHeader)
                        {
                            isHeader = false; // Skip the first line (header)
                            continue;
                        }

                        var parts = line.Split(',');

                        if (parts.Length == 4 &&
                            int.TryParse(parts[0].Trim(), out int id) &&
                            int.TryParse(parts[2].Trim(), out int year))
                        {
                            string name = parts[1].Trim();
                            string genre = parts[3].Trim();

                            Movie movie = new Movie(id, name, year, genre);
                            movieListFromCsv.Add(movie);
                        }
                        else
                        {
                            Console.WriteLine($"Skipping invalid line: {line}");
                        }
                    }
                }

                if (movieListFromCsv.Count == 0)
                {
                    Console.WriteLine("No valid movie records found in the CSV.");
                }
                else
                {
                    Console.WriteLine("\nMovies loaded from CSV:\n");
                    foreach (var movie in movieListFromCsv)
                    {
                        Console.WriteLine(movie.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading from CSV: " + ex.Message);
            }
        }



        public static void Main(string[] args)
        {
            //.WriteLine("Welcome to movie store developed by : Abhay");
            //DisplayMenu();
            string path = @"C:\Users\abhaychandra.gupta\Downloads\Movies.csv";
            LoadMoviesFromCsv(path);


        }
    }
}