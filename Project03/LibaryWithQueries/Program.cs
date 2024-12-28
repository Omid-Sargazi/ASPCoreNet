using System.Text.RegularExpressions;
using LibaryWithQueries;
using LibaryWithQueries.Models;
using Microsoft.EntityFrameworkCore;


class BookLinq {
    public string Title {get;set;}
    public string Genre {get;set;}
}
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");

        var numbers = new List<int> {1,2,3,4,5,6,7,8,9};

        var groupedNumbers = numbers.GroupBy(n=>n%2==0?"E":"O").ToList();
        foreach(var group in groupedNumbers)
        {
            Console.WriteLine($"Group: {group.Key}");
             foreach (var number in group)
    {
        Console.WriteLine($"  - {number}");
    }


    var books = new List<BookLinq> {
         new BookLinq { Title = "Book A", Genre = "Fiction" },
        new BookLinq { Title = "Book B", Genre = "Fiction" },
        new BookLinq { Title = "Book C", Genre = "Science" },
        new BookLinq { Title = "Book D", Genre = "Science" },
        new BookLinq { Title = "Book E", Genre = "History" }
    };


    var booksByGenre = books.GroupBy(b=>b.Genre).ToList();

    foreach(var groups in booksByGenre)
    {
        Console.WriteLine($"Genre: {group.Key}");
        foreach(var book in groups)
        {
            Console.WriteLine($"  - {book.Title}");
        }
    }


















        }

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

        //Retrieve the Most Expensive Book
        var ExpensiveBooks = context.Books.OrderByDescending(b=>b.Price).First();
        Console.WriteLine(ExpensiveBooks.Title);

        //Retrieve the Total Number of Orders for a Specific Book
        var bookTitle = "Harry Potter";
        var totalOrdersForBook = context.Orders
        .Where(o=>o.Book.Title==bookTitle).Count();
        Console.WriteLine($"Total Orders for {bookTitle}: {totalOrdersForBook}");

        //Retrieve Authors with Their Most Expensive Book
        var authorsWithMostExpensiveBook = context.Authors.Select(a=>new {
            AuthorName = a.Name,
            mostExpensiveBook = a.Books.OrderByDescending(b=>b.Price).FirstOrDefault()
        }).ToArray();

        // Retrieve Books Along with Total Orders and Revenue
        var booksWithRevenue = context.Books.Select(b=>new{
            bookTitle = b.Title,
            TotalOrder = b.Orders.Count(),
            TotalRevenue = b.Orders.Sum(o=>o.Book.Price)
        }).ToList();

        foreach(var book in booksWithRevenue)
        {
            Console.WriteLine($"Book: {book.bookTitle}, Total Orders: {book.TotalOrder}, Total Revenue: {book.TotalRevenue}");
        }


        //Group Books by Author
        var allBooksByAuthor = context.Books.GroupBy(b=>b.Author.Name).Select(group=>new{
            AuthorName=group.Key,
            Books = group.Select(b=>b.Title).ToList()
        });


    }


    private static  void SeedDate(ApplicationDbContext context)
    {
        context.Authors.AddRange(
            new Author { AuthorId = 1, Name = "J.K. Rowling" },
            new Author { AuthorId = 2, Name = "George R.R. Martin" },
            new Author { AuthorId = 3, Name = "Omid Sargazi " }
        );

        context.Books.AddRange(
            new Book { BookId = 1, Title = "Harry Potter and the Philosopher's Stone", AuthorId = 1,Price=123.6m },
            new Book { BookId = 2, Title = "A Game of Thrones", AuthorId = 2,Price=45.36m }
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