using Test.Patterns;
namespace Test
{

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");

        MessageServer server = new MessageServer();
        User user1 = new User("Mike");
        User user2 = new User("Omid");
        server.Attach(user1);
        server.Attach(user2);

        server.Message = "Hello users";
    }

    
}
}