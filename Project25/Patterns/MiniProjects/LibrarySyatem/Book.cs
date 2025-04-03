namespace Patterns.MiniProjects.LibrarySyatem
{
    public class book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string ISBN { get; private set; }
       
       public Book(string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Book: {Title} by {Author}, ISBN: {ISBN}");
    }
    }
}
