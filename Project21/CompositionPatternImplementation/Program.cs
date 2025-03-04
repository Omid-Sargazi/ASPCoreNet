using CompositionPatternImplementation.Interfaces;
using CompositionPatternImplementation.Models;

public class Program
{
    public static void Main(string[] args)
    {
        string environment = "Production";
        UserService userService = CompositionRoot.CreateUserService(environment);
        userService.RegisterUser(new User());
    }
}