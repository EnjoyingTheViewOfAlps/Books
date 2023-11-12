using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace books
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public List<string> Tags { get; set; }

        public override string ToString()
        {
            return $"{Title} by {Author} ({Year}), Genre: {Genre}, Tags: {string.Join(", ", Tags)}";
        }
    }
}
