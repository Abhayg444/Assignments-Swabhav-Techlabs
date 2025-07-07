using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQImplementation
{

    public class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public double Rating { get; set; }

        public Movie(string title, string genre, int year, double rating)
        {
            Title = title;
            Genre = genre;
            Year = year;
            Rating = rating;
        }

        public override string ToString()
        {
            return $"{Title} ({Year}) - {Genre} - Rating: {Rating}";
        }
    }
}
