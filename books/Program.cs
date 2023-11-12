using books;

class Program
{
    static void Main()
    {

        BookCatalog catalog = new BookCatalog();

        BookBuilder bookBuilder1 = new BookBuilder();
        BookDirector bookDirector1 = new BookDirector(bookBuilder1);
        bookDirector1.BuildBook("The Hitchhiker's Guide to the Galaxy", "Douglas Adams", 1979, "Science Fiction", new List<string> { "humor", "classic" });
        Book book1 = bookBuilder1.GetBook();
        catalog.AddBook(book1);

        BookBuilder bookBuilder2 = new BookBuilder();
        BookDirector bookDirector2 = new BookDirector(bookBuilder2);
        bookDirector2.BuildBook("1984", "George Orwell", 1949, "Dystopian", new List<string> { "classic", "political" });
        Book book2 = bookBuilder2.GetBook();
        catalog.AddBook(book2);

        Console.WriteLine("Book Catalog:");
        catalog.DisplayBooks();
    }
}