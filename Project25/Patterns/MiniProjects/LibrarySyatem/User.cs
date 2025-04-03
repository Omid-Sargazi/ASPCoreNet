namespace Patterns.MiniProjects.LibrarySyatem
{
    public class User
    {
        public string Name { get; set; }
        public List<Book> BorrowedBooks { get; private set; }

         public User(string name)
        {
            Name = name;
            BorrowedBooks = new List<Book>();
        }

        public void Borrow(Book book)
        {
            BorrowedBooks.Add(book);
        Console.WriteLine($"{Name} borrowed '{book.Title}'");
        }

         public void ShowBorrowedBooks()
    {
        Console.WriteLine($"\n{Name}'s Borrowed Books:");
        foreach (var book in BorrowedBooks)
        {
            book.DisplayInfo();
        }
    }
    }
}