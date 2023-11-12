using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace books
{
    class BookDirector
    {
        private BookBuilder builder;

        public BookDirector(BookBuilder builder)
        {
            this.builder = builder;
        }

        public void BuildBook(string title, string author, int year, string genre, List<string> tags)
        {
            builder.BuildTitle(title);
            builder.BuildAuthor(author);
            builder.BuildYear(year);
            builder.BuildGenre(genre);
            builder.BuildTags(tags);
        }
    }
}
