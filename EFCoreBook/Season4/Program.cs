using Microsoft.EntityFrameworkCore;
using Season4.Data;
using Season4.Models;

public class Program
{
    public static void Main(string[] args)
    {
        using(var db = new AppDbContext())
        {
            var user = new User{Name = "Alice"};
            user.Profile = new UserProfile {Bio = "Software Developer"};

            db.Users.Add(user);
            db.SaveChanges();

            var fetcheUser = db.Users.Include(u => u.Profile).FirstOrDefault();
            Console.WriteLine($"{fetcheUser.Name} has a profile with the bio: {fetcheUser.Profile.Bio}");

            var book = new Book {Title = "Entity Framework Core", Author = "Jon Smith"};
            book.Reviews.Add(new Review {Reviewer = "John", Rating=5});
            book.Reviews.Add(new Review{Reviewer = "Alice", Rating=3});

            db.Books.Add(book);
            db.SaveChanges();

            var fetcheBook = db.Books.Include(b => b.Reviews).FirstOrDefault();
            Console.WriteLine($"{fetcheBook.Title} has {fetcheBook.Reviews.Count} reviews.");
        }
    }
}