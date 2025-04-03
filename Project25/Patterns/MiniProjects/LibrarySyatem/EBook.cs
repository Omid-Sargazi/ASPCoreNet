namespace Patterns.MiniProjects.LibrarySyatem
{
    public class EBook : Book
    {
        public double FileSizeMB {get; private set;}
        public EBook(string title, string author, string isbn, double fileSize):base(title, author, isbn)
        {
            FileSize = fileSize;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Type: EBook, File Size: {FileSizeMB}MB");
        }
    }
}