public class Library
{
    public List<Book> Books { get; } = new List<Book>();
    public List<User> Users { get; } = new List<User>();

    public void AddBook(Book book) => Books.Add(book);
    public void RegisterUser(User user) => Users.Add(user);
}