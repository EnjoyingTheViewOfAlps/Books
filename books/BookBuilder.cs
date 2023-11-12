using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace books
{
    class BookBuilder
    {

        private Book book;

        public BookBuilder()
        {
            book = new Book();
        }

        public void BuildTitle(string title)
        {
            book.Title = title;
        }

        public void BuildAuthor(string author)
        {
            book.Author = author;
        }

        public void BuildYear(int year)
        {
            book.Year = year;
        }

        public void BuildGenre(string genre)
        {
            book.Genre = genre;
        }

        public void BuildTags(List<string> tags)
        {
            book.Tags = tags;
        }

        public Book GetBook()
        {
            return book;
        }
    }
}
