using System;
using System.IO;

namespace Movie_App
{
    public class MovieManager
    {
        private Movie[] movies;
        private int count;
        private const int maxSize = 5;
        private const string filePath = @"D:\Swabhav Training\AuroPay\Assignment\Movie App\Movie App\movies.csv";

        public MovieManager()
        {
            movies = new Movie[maxSize];
            count = 0;
            LoadFromFile();
        }

        public void AddMovie(Movie movie)
        {
            if (count >= maxSize)
            {
                Console.WriteLine("Movie list is full.");
                return;
            }

            movies[count] = movie;
            count++;
            Console.WriteLine("Movie added successfully.");
        }

        public void DisplayMovie()
        {
            if (count == 0)
            {
                Console.WriteLine("No movies to display.");
                return;
            }

            Console.WriteLine("\nMovie List:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(movies[i]);
            }
        }

        public void ClearAllMovies()
        {
            movies = new Movie[maxSize];
            count = 0;
            Console.WriteLine("All movies cleared.");
        }

        public void SaveToFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, false))
                {
                    writer.WriteLine("Id,Name,Genre,Year");
                    for (int i = 0; i < count; i++)
                    {
                        var movie = movies[i];
                        writer.WriteLine($"{movie.id},{movie.name},{movie.genre},{movie.year}");
                    }
                }
                Console.WriteLine("Movies saved to CSV file successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving movies: " + ex.Message);
            }
        }

        public void LoadFromFile()
        {
            try
            {
                if (!File.Exists(filePath))
                    return;

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    bool isHeader = true;

                    while ((line = reader.ReadLine()) != null)
                    {
                        if (isHeader)
                        {
                            isHeader = false;
                            continue;
                        }

                        var parts = line.Split(',');

                        if (parts.Length == 4 &&
                            int.TryParse(parts[0], out int id) &&
                            int.TryParse(parts[3], out int year))
                        {
                            string name = parts[1];
                            string genre = parts[2];

                            movies[count] = new Movie(name, id, genre, year);
                            count++;

                            if (count >= maxSize)
                                break;
                        }
                    }
                }
                Console.WriteLine("-----------------Welcome Back------------");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading movies: " + ex.Message);
            }
        }
    }
}
