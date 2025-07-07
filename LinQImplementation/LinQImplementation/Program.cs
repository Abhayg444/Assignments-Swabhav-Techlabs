namespace LinQImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>
            {
                new Movie("The Godfather", "Crime", 1972, 9.2),
                new Movie("The Shawshank Redemption", "Drama", 1994, 9.3),
                new Movie("The Dark Knight", "Action", 2008, 9.0),
                new Movie("Pulp Fiction", "Crime", 1994, 8.9),
                new Movie("Inception", "Sci-Fi", 2010, 8.8),
                new Movie("The Matrix", "Sci-Fi", 1999, 8.7),
                new Movie("Titanic", "Romance", 1997, 7.9),
                new Movie("The Prestige", "Drama", 2006, 8.5),
                new Movie("Gladiator", "Action", 2000, 8.5)
            };

            var crimeMovies = movies.Where(m => m.Genre == "Crime");
            Console.WriteLine("Crime Movies:");
            foreach (var movie in crimeMovies)
                Console.WriteLine(movie);

            Console.WriteLine();

            var sortedMovies = movies.OrderBy(m => m.Title);
            Console.WriteLine("Movies Sorted by Title:");
            foreach (var movie in sortedMovies)
                Console.WriteLine(movie);

            Console.WriteLine();

            var moviesAfter2000 = movies.Where(m => m.Year > 2000);
            Console.WriteLine("Movies Released After 2000:");
            foreach (var movie in moviesAfter2000)
                Console.WriteLine(movie);

            Console.WriteLine();

            var movieTitles = movies.Select(m => m.Title).ToList();
            Console.WriteLine("Movie Titles:");
            movieTitles.ForEach(Console.WriteLine);

            Console.WriteLine();

            var highRatedCount = movies.Count(m => m.Rating > 8.5);
            Console.WriteLine($"Number of Movies with Rating > 8.5: {highRatedCount} \n");
            Console.WriteLine();

            var moviesByGenre = movies.GroupBy(m => m.Genre);
            Console.WriteLine("Movies Grouped by Genre:");
            foreach (var group in moviesByGenre)
            {
                Console.WriteLine($"\nGenre: {group.Key}");
                foreach (var movie in group)
                    Console.WriteLine(movie);
            }

            Console.WriteLine();

            var topMovie = movies.OrderByDescending(m => m.Rating).First();
            Console.WriteLine($"Highest Rated Movie: {topMovie}  \n ");

            var averageRating = movies.Average(m => m.Rating);
            Console.WriteLine($"Average Rating of All Movies: {averageRating:F2} \n");

            var has90sMovie = movies.Any(m => m.Year >= 1990 && m.Year <= 1999);
            Console.WriteLine($"Is there any movie from the 90s? {has90sMovie}\n");

            var moviesStartingWithT = movies.Where(m => m.Title.StartsWith("T"));
            Console.WriteLine("Movies Starting with 'T':");
            foreach (var movie in moviesStartingWithT)
                Console.WriteLine(movie);

            Console.WriteLine();

            var paginatedMovies = movies.Skip(2).Take(2);
            Console.WriteLine("Paginated Movies (Skip 2, Take 2):");
            foreach (var movie in paginatedMovies)
                Console.WriteLine(movie);

            Console.WriteLine();

            var top3Movies = movies.OrderByDescending(m => m.Rating).Take(3);
            Console.WriteLine("Top 3 Rated Movies:");
            foreach (var movie in top3Movies)
                Console.WriteLine(movie);

            Console.WriteLine();

            var firstSciFiMovie = movies.FirstOrDefault(m => m.Genre == "Sci-Fi");
            Console.WriteLine($"First Sci-Fi Movie: {firstSciFiMovie} \n");

            var allAbove8 = movies.All(m => m.Rating > 8);
            Console.WriteLine($"Do all movies have a rating above 8? {allAbove8}\n");

        }
    }
}
