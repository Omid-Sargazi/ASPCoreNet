namespace Patterns.Example01
{
    public class Library
{
    public string Name { get; set; }
    public List<Book> Books { get; set; }
    
    public Library(string name)
    {
        Name = name;
        Books = new List<Book>();
    }
    
    public void AddBook(Book book)
    {
        Books.Add(book);
    }
    
    public void RemoveBook(Book book)
    {
        Books.Remove(book);
    }
}