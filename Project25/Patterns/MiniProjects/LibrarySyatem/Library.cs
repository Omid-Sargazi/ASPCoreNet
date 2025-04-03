namespace Patterns.MiniProjects.LibrarySyatem
{
    public class Library{
        public List<Book> Books { get; private set; } = new();

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public void ShowAllBooks()
    {
        Console.WriteLine("\nLibrary Books:");
        foreach (var book in Books)
        {
            book.DisplayInfo();
        }
    }
    }
}