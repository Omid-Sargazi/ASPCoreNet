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

            //Get all books by a specific author.
            var authorName = "J.K. Rowling";
            var books = context.Authors.Where(a => a.Name == authorName).SelectMany(a=>a.Books).ToList();
            Console.WriteLine($"all books for {authorName}");
            foreach(var book in books)
            {
                Console.WriteLine(book.Title);
            }

            //Get all books by a specific author.
            var booksAuthors = context.Books.Where(b => b.Author.Name == authorName).ToList();
            
            //Get an author’s contact details.
        //    var contact = context.Authors.Where(a => a.Name == authorName).ToList();
            var contact = context.AuthorContacts.Where(ac => ac.Author.Name == authorName).ToList();
           Console.WriteLine($"Get contact details {authorName}");
           foreach(var detais in contact)
           {
            Console.WriteLine(detais.Email +detais.Phone+ detais.Id);
           }
           
           //Get all books in a specific category.
           var categoryName = "Fantasy";
           var booksInSpecificCategory = context.BookCategories.Where(bc => bc.Category.Name == categoryName).Select(bc =>new{Books = bc.Book.Title}).ToList();
           Console.WriteLine($"Get all books in a specific category{categoryName}");
           foreach(var book in booksInSpecificCategory)
           {
            Console.WriteLine($"{book}");
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