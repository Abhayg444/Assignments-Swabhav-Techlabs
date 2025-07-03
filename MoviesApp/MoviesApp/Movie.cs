using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesApp
{
    public class NotMorethan5Movies : Exception
    {
        public NotMorethan5Movies(string message)
        {
            Console.WriteLine(message);
        }

    }
    public class InvalidIdException : Exception
    {
        public InvalidIdException(string message)
        {
            Console.WriteLine(message);
        }

    }
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int YearofRelease { get; set; }
        public string Genre { get; set; }

        public Movie(int id, string name, int yearofRelease, string genre)
        {
            Id = id;
            Name = name;
            YearofRelease = yearofRelease;
            Genre = genre;
        }

        public override string ToString()
        {
            return $"Movie ID: {Id} \nMovie Name: {Name} \nMovie Genre: {Genre} \nYear of Release: {YearofRelease}\n\n";

        }
    }
    public class MovieManager
    {
        Dictionary<int, Movie> movies = new Dictionary<int, Movie>();
        public void AddMovie()
        {
            if (movies.Count > 5)
            {
                throw new NotMorethan5Movies("More than 5 movies are not allowed");
            }

            else
            {
                Console.Write("Movie id: ");
                int Id = int.Parse(Console.ReadLine());
                Console.Write("Movie name: ");
                string name = Console.ReadLine();
                Console.Write("Year of Release: ");
                int year = int.Parse(Console.ReadLine());
                Console.Write("Movie Genre: ");
                string genre = Console.ReadLine();

                Movie m1 = new Movie(Id, name, year, genre);

                movies.Add(Id, m1);
                Console.WriteLine("Movie added sucessfully!");
            }
        }

        public void DisplayAll()
        {
            foreach (Movie m in movies.Values)
            {
                Console.WriteLine(m.ToString());
            }
        }

        public void FindbyId()
        {
            Console.Write("Enter Movie ID: ");
            int id = int.Parse(Console.ReadLine());
            if (movies.ContainsKey(id))
            {
                Console.WriteLine(movies[id]+"\n");
            }
            else { throw new InvalidIdException("Movie ID not found"); }
        }

        public void RemovebyID()
        {
            Console.Write("Enter Movie ID: ");
            int id = int.Parse(Console.ReadLine());
            if (movies.ContainsKey(id))
            {
                movies.Remove(id);
                Console.WriteLine("Movie removed successfully..\n");
            }
            else { throw new InvalidIdException("Movie ID not found"); }
        }

        public void RemoveAll()
        {
            movies.Clear();
            Console.WriteLine("Movies removed successfully..\n");

        }
    }
}

