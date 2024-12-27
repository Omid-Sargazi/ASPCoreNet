using LibraryForQUery;
using LibraryForQUery.Models;
using Microsoft.EntityFrameworkCore;

public class Program
{
    public static void Main(string[] args)
    {
       Console.WriteLine("Hello");

       var context = new SchoolContext();
       SeedData(context);
       //Get all publishers with the count of books they have published.

       var publishers = context.Publishers.Include(p=>p.Books).Select(b=>new {
              Publisher = b.Name,
              BookCount = b.Books.Count
       }).ToList();

       foreach(var publisher in publishers)
       {
        Console.WriteLine(publisher.Publisher + " " + publisher.BookCount);
       }
        ///More optimized than the previous example
        var publisher02 = context.Publishers.Select(p=>new {
            Publisher = p.Name,
            BookCount=p.Books.Count,
        });

        foreach(var publisher in publisher02)
        {
            Console.WriteLine($"{publisher.Publisher} has {publisher.BookCount} books.");
        }

        //Find all books written by "Author 1" and include their publisher's name
        var booksByAuthor1 = context.Books.Include(b=>b.Author).Include(b=>b.Publisher).Select(b=>new{
            Book = b.Title,
            Author = b.Author.Name,
            Publisher = b.Publisher.Name
        }).Where(b=>b.Author == "Author 1").ToList();

        var booksByAuthor1_02 = context.Books.Include(b=>b.Author).Include(b=>b.Publisher).Where(b=>b.Author.Name == "Author 1").Select(b=>new{
            Book = b.Title,
            Author = b.Author.Name,
            Publisher = b.Publisher.Name
        }).ToList();

        //Find all authors who have published more than 2 books and display their names along with the number of books

        var authorsMoreThan2Books = context.Authors.Include(a=>a.Books).Select(a=>new {
            Author = a.Name,
            BookCount = a.Books.Count
        }).Where(a=>a.BookCount > 2).ToList();

    }


    private static void SeedData(SchoolContext context)
    {
        var publisher1 = new Publisher { Name = "Publisher A" };
        var publisher2 = new Publisher { Name = "Publisher B" };

        var author1 = new Author { Name = "Author 1" };
        var author2 = new Author { Name = "Author 2" };


        var books = new List<Book>
        {
            new Book { Title = "Book 1", PublishedYear = 2020, Author = author1, Publisher = publisher1 },
            new Book { Title = "Book 2", PublishedYear = 2021, Author = author1, Publisher = publisher2 },
            new Book { Title = "Book 3", PublishedYear = 2019, Author = author2, Publisher = publisher1 },
            new Book { Title = "Book 4", PublishedYear = 2022, Author = author2, Publisher = publisher2 }
        };


        context.Publishers.AddRange(publisher1, publisher2);
        context.Authors.AddRange(author1, author2);
        context.Books.AddRange(books);

        context.SaveChanges();
    }
}