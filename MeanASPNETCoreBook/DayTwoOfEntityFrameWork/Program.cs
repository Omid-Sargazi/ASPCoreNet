using DayTwoOfEntityFrameWork.Data;
using Microsoft.EntityFrameworkCore;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");

        using(var db = new AppDbContext())
        {
            db.Database.EnsureCreated();
            var authors = db.Authors.ToList();
            var books = db.Books.ToList();
            foreach(var author in authors)
            {
                Console.WriteLine(author.Name);
            }

            foreach(var book in books)
            {
                Console.WriteLine(book.Title);
            }

            var author1 = db.Authors.Where(a => a.AuthorId == 1).ToList();
            Console.WriteLine($"Author: {author1.First().Name}");

            var FindBook = db.Books.Find(1);
            Console.WriteLine($"Book: {FindBook.Title}");

            ///////Filtering///////////////////////////
            Console.WriteLine("////////////Filtering///////////");
            var booksByAuthor = db.Books.Where(b => b.AuthorId == 1).ToList();

            var efCoreBooks = db.Books.Where(b => b.Title.Contains("EF Core")).ToList();
            var greatReviews = db.Reviews.Where(r => r.Comment.Contains("Great")).ToList();
            var popularBooks = db.Books.Where(b => b.Reviews.Count > 1).ToList();
            var Omid = db.Authors.Where(a => a.Name == "Omid").ToList();

            /////////////////////////sortedBooks////////////////////////
            Console.WriteLine("////////////Sorted Books///////////");
            var sortedBooks = db.Books.OrderBy(b => b.Title).ToList();
            var sortedBooksDesc = db.Books.OrderByDescending(b => b.Title).ToList();
            var sortedReviews = db.Reviews.OrderBy(r => r.Comment.Length).ToList();
            var sortedAuthors = db.Authors.OrderBy(a =>a.Name).ToList();
            var booksByReviewCount = db.Books.OrderBy(b =>b.Reviews.Count).ToList();
            //////////////Pagination///////////////////////////////
            Console.WriteLine("////////////Pagination///////////");

            var firstTwoBooks = db.Books.Take(2).ToList();
            Console.WriteLine("First Two Books");
            foreach(var book in firstTwoBooks)
            {
                Console.WriteLine(book.Title);
            }
            var secondPage = db.Books.Skip(2).Take(2).ToList();
            Console.WriteLine("/////////////////////////Second Page/////////////////////////////");
            foreach(var book in secondPage)
            {
                Console.WriteLine(book.Title);
            }

            var firstThreeReviews = db.Reviews.Take(3).ToList();
            Console.WriteLine("/////////////////////////First Three Reviews/////////////////////////////");
            foreach(var review in firstThreeReviews)
            {
                Console.WriteLine(review.Comment);
            }

            var secondPageReviews = db.Reviews.Skip(2).Take(2).ToList();
            var firstTwoAuthors = db.Authors.Take(2).ToList();
            ///////////////////////////Get books with their authors///////////////////////////////
            Console.WriteLine("/////////////////////////Get books with their authors/////////////////////////////");
            var booksWithAuthors = db.Books.Include(b =>b.Author).ToList();
            var authorsWithBooks = db.Authors.Include(a => a.Books).ToList();
            var booksWithReviews = db.Books.Include(b =>b.Reviews).ToList();
            var reviewsWithBooks = db.Reviews.Include(r => r.Book).ToList();
            var authorsWithBooksAndReviews = db.Authors.Include(a => a.Books).ThenInclude(b => b.Reviews).ToList();
            ///////////////////////////Advanced Queries/////////////////////////////////////////
            Console.WriteLine("/////////////////////////Advanced Queries/////////////////////////////");
            var booksPerAuthor = db.Authors.Select(a => new {a.Name, BookCount = a.Books.Count}).ToList();
            var avgReviews = db.Books.Average(b =>b.Reviews.Count);
            var booksWithoutReviews = db.Books.Where(b => b.Reviews.Count == 0).ToList();
            var mostReviewedBook = db.Books.OrderByDescending(b => b.Reviews.Count).FirstOrDefault();
        }

    }
}