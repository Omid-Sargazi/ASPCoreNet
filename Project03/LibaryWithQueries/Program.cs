using System.Text.RegularExpressions;
using LibaryWithQueries;
using LibaryWithQueries.Models;
using Microsoft.EntityFrameworkCore;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");

        var context = new ApplicationDbContext();
        SeedDate(context);

        int authorId = 1;


        var booksByAuthor = context.Books.Where(b=>b.AuthorId==authorId).ToList();

        foreach(var item in booksByAuthor)
        {
            Console.WriteLine(item.Title);
        }


        var customersWithBooks = context.Orders.Select(o=>new {
            o.Customer.FullName,
            o.Book.Title
        }).ToList();


        var popularBooks = context.Orders
        .GroupBy(o=>new {o.BookId,o.Book.Title})
        .Where(group=>group.Count()>1).Select(g=>new{
            bookTitle = g.Key.Title,
            orderCount=g.Count(),
        }).ToList();

        //list of authors who have written more than one book
        
        var popularAuthors = context.Authors.Select(a=>new{
            Name=a.Name,
            CountBook = a.Books.Count,
        }).ToList();


        //Retrieve All Books Ordered by Title
        var booksOrderedByTitle = context.Books.OrderBy(b=>b.Title).ToList();

        foreach(var book in booksOrderedByTitle)
        {
            Console.WriteLine(book.Title);
        }

        var authorsWithNoBooks = context.Authors.Where(a=>!a.Books.Any()).ToList();

        foreach(var author in authorsWithNoBooks)
        {
             Console.WriteLine($"Authors: {author.Name}");
        }
    }


    private static  void SeedDate(ApplicationDbContext context)
    {
        context.Authors.AddRange(
            new Author { AuthorId = 1, Name = "J.K. Rowling" },
            new Author { AuthorId = 2, Name = "George R.R. Martin" },
            new Author { AuthorId = 3, Name = "Omid Sargazi " }
        );

        context.Books.AddRange(
            new Book { BookId = 1, Title = "Harry Potter and the Philosopher's Stone", AuthorId = 1 },
            new Book { BookId = 2, Title = "A Game of Thrones", AuthorId = 2 }
        );

        context.Customers.AddRange(
            new Customer { CustomerId = 1, FullName = "John Doe" },
            new Customer { CustomerId = 2, FullName = "Jane Smith" }
        );

        context.Orders.AddRange(
            new Order { OrderId = 1, CustomerId = 1, BookId = 1, OrderDate = DateTime.Now },
            new Order { OrderId = 2, CustomerId = 2, BookId = 2, OrderDate = DateTime.Now }
        );

        context.SaveChanges();
    }
}