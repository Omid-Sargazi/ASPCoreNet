using Microsoft.EntityFrameworkCore;
using SqlServerLinq.Data;
using SqlServerLinq.Models;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");

        

        var builder = WebApplication.CreateBuilder(args);
        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

        builder.Services.AddDbContext<AppDbContext>(options=>{
            options.UseSqlServer(connectionString);
        });
        var app = builder.Build();

        using(var scope = app.Services.CreateScope() )
        {
            var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            context.Database.EnsureCreated();
            SeedData(context);

            var studentName = context.Students.Select(s =>s.Name).ToList();
            Console.WriteLine("Students:"+ string.Join(", ",studentName));


            var youngStudents = context.Students.Where(s => s.Age < 22).ToList();
            foreach(var student in youngStudents)
            {
                Console.WriteLine($"Young Student: {student.Name}, Age:{student.Age}");
            }

            //Advanced Queries
            var studentCourses = context.Enrollments
            .Join(context.Students, e=>e.StudentId,s=>s.StudentId,(e,s)=>new {e,s})
            .Join(context.Courses,es=>es.e.CourseId,c=>c.CourseId,(es,c)=> new{
                studentName = es.s.Name,
                courseTitle = c.Title,
            }).ToList();

        }
    }


    private static void SeedData(AppDbContext context)
    {
        var students = new List<Student>
        {
            new() { Name = "Alice", Age = 20 },
            new() { Name = "Bob", Age = 22 },
            new() { Name = "Charlie", Age = 23 }
         };
        var courses = new List<Course>
        {
            new() { Title = "Math", Instructor = "Dr. Smith" },
            new() { Title = "Physics", Instructor = "Dr. Brown" },
            new() { Title = "Chemistry", Instructor = "Dr. Taylor" }
        };

        var enrollments = new List<Enrollment>
    {
        new() { Student = students[0], Course = courses[0] },
        new() { Student = students[0], Course = courses[1] },
        new() { Student = students[1], Course = courses[1] },
        new() { Student = students[2], Course = courses[2] }
    };

         context.Students.AddRange(students);
        context.Courses.AddRange(courses);
        //context.Enrollments.AddRange(enrollments);
        context.SaveChanges();
    }
}