using Microsoft.EntityFrameworkCore;
using Test01.SqlServer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddControllers();

// using(var context = new AppDbContext())
// {
//     {
//             // Add sample data if the database is empty
//             if (!context.Authors.Any())
//             {
//                 var author = new Author
//                 {
//                     Name = "George Orwell",
//                     Books = new List<Book>
//                     {
//                         new Book { Title = "1984" },
//                         new Book { Title = "Animal Farm" }
//                     }
//                 };

//                 context.Authors.Add(author);
//                 context.SaveChanges();
//             }
//         }
// }

builder.Services.AddDbContext<AppDbContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")).LogTo(Console.WriteLine, LogLevel.Information));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.MapControllers();

app.Run();

