using CatalogContext;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IBookRepository, InMemoryBookRepository>();

builder.Services.AddControllers();



// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();



app.Run();

