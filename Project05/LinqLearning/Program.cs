using LinqLearning.Data;
using LinqLearning.Models;

var context = new AppDbContext();

context.Database.EnsureDeleted();
context.Database.EnsureCreated();


if(!context.Students.Any())
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
    context.Enrollments.AddRange(enrollments);

    context.SaveChanges();
}

Console.WriteLine("Database seeded!");

var studentNames = context.Students.Select(s=>s.Name).ToList();
foreach (var name in studentNames)
{
    Console.WriteLine("Students: " + string.Join(", ", name));
}


var youngStudents = context.Students.Where(s=>s.Age<22).ToList();
foreach (var student in youngStudents)
{
    Console.WriteLine($"Young Student: {student.Name}, Age: {student.Age}");
}



//Advanced Queries
var studentCourses = context.Enrollments.Join(context.Students,e=>e.StudentId,s=>s.StudentId,(e,s)=>new {e,s})
    .Join(context.Courses,sc=>sc.e.CourseId,c=>c.CourseId,(sc,c)=>new {sc,c})
    .Select(x=>new {x.sc.s.Name,x.c.Title})
    .ToList();


var studentCourses2 = context.Enrollments.Select(e=>new{
    studentName = e.Student.Name,
    CourseTitle = e.Course.Title,
}).ToList();

foreach(var item in studentCourses2)
{
    Console.WriteLine($"Student: {item.studentName}, Course: {item.CourseTitle}");
}