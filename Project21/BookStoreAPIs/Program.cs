using System.Threading.Tasks;
using BookStoreAPIs.Data;
using BookStoreAPIs.Repositories;
using Microsoft.EntityFrameworkCore;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddDbContext<BookStoreContext>(options=>{
            options.UseSqlite("Data Source=app.db");
        });

        builder.Services.AddScoped<IBookRepository,BookRepository>();

        builder.Services.AddControllers();

        var app = builder.Build();

        app.UseHttpsRedirection();

        app.MapControllers();

        using(var scope = app.Services.CreateScope())
        {
            var services = scope.ServiceProvider;
            try{
                var logger = services.GetRequiredService<ILogger<Program>>();
                logger.LogInformation("Starting database initialization");
                await BookStoreDbInitializer.Initialize(services);
            }
            catch(Exception ex)
            {
                var logger = services.GetRequiredService<ILogger<Program>>();
                logger.LogError(ex, "An error occurred while initializing the database");
            }
        }

        app.Run();
    }
}