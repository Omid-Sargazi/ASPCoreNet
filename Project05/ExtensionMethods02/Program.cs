using ExtensionMethods02.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
        var service = new UserService();
        var filteredUsers = service.GetFilteredUsers("Alice", 25, 30);


         foreach (var user in filteredUsers)
        {
            Console.WriteLine($"{user.Name}, {user.Age}, {user.Email}");
        }
    }

    public static IHostBuilder CreateHostBuilder(string[] args)=>Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder=>
    
    {
        webBuilder.UseStartup<Startup>();
    }
    )
}


public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
    }
}