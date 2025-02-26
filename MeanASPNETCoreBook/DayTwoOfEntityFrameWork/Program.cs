using DayTwoOfEntityFrameWork.Data;

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
        }
    }
}