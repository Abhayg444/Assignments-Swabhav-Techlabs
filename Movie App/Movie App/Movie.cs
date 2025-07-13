using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_App
{
    public class Movie
    {
        public string name;
        public int id;
        public string genre;
        public int year;

        public Movie(string name, int id, string genre, int year)
        {
            this.name = name;
            this.id = id;
            this.genre = genre;
            this.year = year;
        }

        public override string ToString()
        {
            return $"Name {name}, \nID: {id}, \nGenre: {genre}, \nYear: {year}\n";
        }
    }
}
