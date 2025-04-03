namespace Patterns.MiniProjects.LibrarySyatem
{
    public class LibraryCard
    {
        public string CardNumber { get; private set; }

        public LibraryCard(string number)
        {
            CardNumber = number;
        }

        public void ShowCardInfo()
        {
            Console.WriteLine($"Library Card: {CardNumber}");
        }
    }
}