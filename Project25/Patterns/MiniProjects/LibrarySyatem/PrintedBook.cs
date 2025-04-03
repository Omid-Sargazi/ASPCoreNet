namespace Patterns.MiniProjects.LibrarySyatem
{
    public class PrintedBook : Book{
        public int PageCount { get; private set; }

        public PrintedBook(string title, string author, string isbn, int pages):base(title, author, isbn)
        {
            PageCount = pages;
        }
        
        public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Type: Printed Book, Pages: {PageCount}");
    }
    }
}