using LibraryForQUery;
using LibraryForQUery.Models;

public class Program
{
    public static void Main(string[] args)
    {
       Console.WriteLine("Hello");

    }


    private void SeedData(SchoolContext context)
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