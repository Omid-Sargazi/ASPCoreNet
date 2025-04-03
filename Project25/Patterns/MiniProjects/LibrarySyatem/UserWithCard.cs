namespace Patterns.MiniProjects.LibrarySyatem
{
    public class UserWithCard
    {
        public string Name {get; private set;}
        public LibraryCard Card { get; private set; }

         public UserWithCard(string name, string cardNumber)
        {
            Name = name;
            Card = new LibraryCard(cardNumber); // Composition
        }
        public void ShowUserInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Card.ShowCardInfo();
        }
    }
}