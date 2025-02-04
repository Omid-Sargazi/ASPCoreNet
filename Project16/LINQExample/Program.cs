using LINQExample.Data;
using LINQExample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("hello sql");

        var builder = WebApplication.CreateBuilder(args);

        var connectionString = builder.Configuration.GetConnectionString("defaultConnection");
        builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));
        
        var app = builder.Build();

        using(var scope = app.Services.CreateScope())
        {
            var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            //context.Database.EnsureCreated();
            SeedDate(context);
            var authors = context.Authors.ToList();
            foreach(var author in authors)
            {
                Console.WriteLine(author.Name);
            }

        }
    }


    private static void SeedDate(AppDbContext context)
    {
        if(!context.Authors.Any())
        {
             var authors = new List<Author>
        {
            new Author { Name = "J.K. Rowling" },
            new Author { Name = "George R.R. Martin" }
        };

        context.Authors.AddRange(authors);
        context.SaveChanges();

        var books = new List<Book>
            {
            new Book { Title = "Harry Potter and the Philosopher's Stone", AuthorId = 1 },
            new Book { Title = "A Game of Thrones", AuthorId = 2 }
            };
        context.Books.AddRange(books);
        context.SaveChanges();

        var categories = new List<Category>
             {
            new Category { Name = "Fantasy" },
            new Category { Name = "Adventure" }
            };
        context.Categories.AddRange(categories);
        context.SaveChanges();

        var bookCategories = new List<BookCategory>
        {
            new BookCategory { BookId = 1, CategoryId = 1 },
            new BookCategory { BookId = 1, CategoryId = 2 },
            new BookCategory { BookId = 2, CategoryId = 1 }
        };
        context.BookCategories.AddRange(bookCategories);
        context.SaveChanges();

         var authorContacts = new List<AuthorContact>
        {
            new AuthorContact { Email = "jkrowling@example.com", Phone = "123-456-7890", AuthorId = 1 },
            new AuthorContact { Email = "grrmartin@example.com", Phone = "987-654-3210", AuthorId = 2 }
        };
        context.AuthorContacts.AddRange(authorContacts);
        context.SaveChanges();


        }
    }
}