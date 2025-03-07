using Serilog;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");

        var builder = WebApplication.CreateBuilder(args);
        Log.Logger = new LoggerConfiguration()
        .MinimumLevel.Information()
        .WriteTo.Console()
        .WriteTo.File("logs/app.log",rollingInterval: RollingInterval.Day).CreateLogger();

        builder.Host.UseSerilog();

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();


        var app = builder.Build();


        app.Lifetime.ApplicationStopped.Register(Log.CloseAndFlush);
        app.Run();
    }
}