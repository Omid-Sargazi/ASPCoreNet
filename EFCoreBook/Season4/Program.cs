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
        }
    }
}