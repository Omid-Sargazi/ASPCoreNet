using System.Threading.Tasks;
using LinqQueryWithSqlServer.Data;
using LinqQueryWithSqlServer.Models;
using Microsoft.EntityFrameworkCore;

public class Program
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine("Hello Linq");
       
       var builder = WebApplication.CreateBuilder(args);
       
       var connetionString = builder.Configuration.GetConnectionString("DafaultConnection");
       builder.Services.AddDbContext<AppDbContext>(options=>{
        options.UseSqlServer(connetionString);
       });


       var app = builder.Build();

       using(var scope = app.Services.CreateScope())
       {
            var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            context.Database.EnsureCreated();
            SeedDate(context);

            Console.WriteLine("Database created and located seed data");
       }
    }

    private static void SeedDate(AppDbContext context)
    {
        var students = new List<Student>
        {
            new () {Name = "Alice", Age=20},
            new () {Name = "Bob", Age=22},
            new () {Name = "Charlie", Age=40},
        };

        var courses = new List<Course> {
           new() { Title = "Math", Instructor = "Dr. Smith" },
           new() { Title = "Physics", Instructor = "Dr. Brown" },
           new() { Title = "Chemistry", Instructor = "Dr. Taylor" },
        };

        var enrollments = new List<Enrollment> {
            new () {Student = students[0], Course = courses[0]},
            new () {Student = students[0], Course = courses[1] },
            new () {Student = students[1], Course = courses[1]},
            new () {Student = students[2], Course = courses[2]}

        };

        context.Students.AddRange(students);
        context.Courses.AddRange(courses);
        context.Enrollments.AddRange(enrollments);
        context.SaveChanges();
    }
}