using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace books
{
    class BookCatalog
    {
        private Stack<Book> bookStack;

        public BookCatalog()
        {
            bookStack = new Stack<Book>();
        }

        public void AddBook(Book book)
        {
            bookStack.Push(book);
        }

        public void DisplayBooks()
        {
            foreach (var book in bookStack)
            {
                Console.WriteLine(book);
            }
        }
    }
}
