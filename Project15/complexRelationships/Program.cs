using complexRelationships.Data;
using complexRelationships.models;
using Microsoft.EntityFrameworkCore;

public class Program
{
    public static void Main(string[] args)
    {
        // Console.WriteLine("Hello");

        var builder = WebApplication.CreateBuilder(args);

        var connetionStrings = builder.Configuration.GetConnectionString("DafaultConnectionString");

        builder.Services.AddDbContext<AppDbContext>(options=>
            options.UseSqlServer(connetionStrings)
        );

        var app = builder.Build();
        using(var scope = app.Services.CreateScope())
        {
            Console.WriteLine("hello");
            var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            context.Database.EnsureCreated();
            SeedDate(context);
        }

        using( var scope = app.Services.CreateScope())
        {
            Console.WriteLine("hello scope");
            var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            var books = context.Books.ToList();
            Console.WriteLine("All Books");
            foreach(var item in books)
            {
                Console.WriteLine($"{item.Title}");
            }

            Console.WriteLine("***********Get all books by a specific author**************");
            var authorName = context.Books.Select(b => new {b.Title, b.Author.Name}).ToList();
            var AuthorName = "J.K. Rowling";
            var booksWithSpecificAuthor = context.Books
            .Where(b => b.Author.Name == AuthorName).ToList();
            Console.WriteLine($"Books by {AuthorName}");
            foreach(var item in booksWithSpecificAuthor)
            {
                Console.WriteLine($"{item.Title}");
            }

            Console.WriteLine("***********Querying One-to-One Relationships***************");
            //Get an author’s contact details.

            var authorContact = "J.K. Rowling";
            var contact = context.Authors
            .Where(a => a.Name == authorContact)
            .Select(a => new{a.Name, a.Contact.Email, a.Contact.Phone}).ToList();
            Console.WriteLine("Details of Authors;");
            foreach(var item in contact)
            {
                Console.WriteLine($" {item.Name}, {item.Email}, {item.Phone}");
            }


            var bookTitle = "Harry Potter and the Philosopher's Stone";
            var categories = context.Books.Where(b => b.Title == bookTitle)
            .SelectMany(b => b.BookCategories.Select(bc=>bc.Category)).ToList();

            Console.WriteLine($"Categories for {bookTitle}:");
            foreach(var item in categories)
            {
                Console.WriteLine(item.Name);
            }

            //Get all books in a specific category.

            var categoryName = "Fantasy";
            var booksSpecificCategory = context.Categories
            .Where(c => c.Name == categoryName)
            .SelectMany(c=>c.BookCategories.Select(bc => bc.Book))
            .ToList();

            Console.WriteLine($"Books in {categoryName}:");
            foreach(var book in books)
            {
                Console.WriteLine(book.Title);
            }

            //Querying with Multiple Joins
            Console.WriteLine("**********Get all books with their authors and categories**********");
            var booksWithAuthorCategories = context.Books
            .Include(b => b.Author)
            .Include(b => b.BookCategories)
            .ThenInclude(bc => bc.Category)
            .ToList();

            Console.WriteLine("Books with Authors and Categories;");
            foreach(var book in booksWithAuthorCategories)
            {
                Console.WriteLine($"{book.Title} {book.Author.Name}");
                foreach(var category in book.BookCategories.Select(bc => bc.Category))
                {
                    Console.WriteLine($" Category{category.Name}");
                }
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