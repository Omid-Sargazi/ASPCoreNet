using LINQDemoApp;
using LINQDemoApp.Models;
using Microsoft.EntityFrameworkCore;


public class Program
{
    public static void Main(string[] args)
    {
        using var context = new AppDbContext();

        SeedData(context);
        Console.WriteLine("All Customers and their Orders:");
        var authors = context.Authors.Include(a=>a.Books).ToList();

        foreach(var author in authors)
        {
            Console.WriteLine($"Author: {author.Name}");
            foreach(var book in author.Books)
            {
                Console.WriteLine($"  Book: {book.Title}, Year: {book.PublishedYear}");
            }
        }


        Console.WriteLine("\nBooks published after 2020:");

        var recentBooks = context.Books.Where(b=>b.PublishedYear>2020).ToList();

        foreach(var book in recentBooks)
        {
            Console.WriteLine($"Book: {book.Title}, Year: {book.PublishedYear}");
        }

         Console.WriteLine("\nCount of Books per Author:");

         var bookCounts = context.Authors.Select(a=>new {
            AuthorName = a.Name,
            bookCounts = a.Books.Count
         }).ToList();

         foreach(var count in bookCounts)
         {
            Console.WriteLine($"Author: {count.AuthorName}, Books: {count.bookCounts}");
         }

    }

    private static void SeedData(AppDbContext context)
{
    if(!context.Authors.Any())
    {
        var author1 = new Author { Name = "Author A" };
        var author2 = new Author { Name = "Author B" };

        author1.Books.Add(new Book { Title = "Book 1", PublishedYear = 2020 });
        author1.Books.Add(new Book { Title = "Book 2", PublishedYear = 2021 });

        author2.Books.Add(new Book { Title = "Book 3", PublishedYear = 2019 });
        author2.Books.Add(new Book { Title = "Book 4", PublishedYear = 2022 });

        context.Authors.AddRange(author1,author2);
        context.SaveChanges();

    }
}







}



