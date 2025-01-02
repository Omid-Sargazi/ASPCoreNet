using ExtensionMethods02.Services;

public class Program
{
    public static void Main(string[] args)
    {
        var service = new UserService();
        var filteredUsers = service.GetFilteredUsers("Alice", 25, 30);


         foreach (var user in filteredUsers)
        {
            Console.WriteLine($"{user.Name}, {user.Age}, {user.Email}");
        }
    }
}