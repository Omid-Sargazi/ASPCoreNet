using System.Xml.Serialization;
using Microsoft.EntityFrameworkCore;
using SchoolLinq;
using SchoolLinq.Models;



    void SeedData(SchoolContext context)
    {
        if(!context.Students.Any())
        {
            var student1 = new Student{Name="omid",Age=41};
            var student2 = new Student{Name="Saeed",Age=39};

            var course1 = new Course{Title="Math",Credits=3};
            var course2 = new Course{Title="Computer",Credits=4};


            context.Students.AddRange(student1,student2);
            context.Courses.AddRange(course1,course2);

            context.SaveChanges();

            context.Enrollments.AddRange(
                new Enrollment{StudentId=student1.Id,CourseId=course1.Id,Grade="A"},
                new Enrollment{StudentId=student1.Id,CourseId=course2.Id,Grade="B"},
                new Enrollment{StudentId= student2.Id,CourseId=course1.Id,Grade="C"}
            );
            context.SaveChanges();
        }
    }


using(var context = new SchoolContext())
{
    SeedData(context);

    
    var studentsWithCourses = context.Students
    .Include(s=>s.Enrollments).ThenInclude(e=>e.Course).Select(s=>new {
        s.Name,
        Courses = s.Enrollments.Select(e=>new
        {
            e.Course.Title,
            e.Grade
        })
    });



    Console.WriteLine("Students with their courses and grades:");

    foreach(var student in studentsWithCourses)
    {
        Console.WriteLine($"Student: {student.Name}");

        foreach (var course in student.Courses)
        {
            Console.WriteLine($" - Course: {course.Title}, Grade: {course.Grade}");
        }
        }
    

   var coursesWithStudentCount = context.Courses
        .Select(c => new
        {
            c.Title,
            StudentCount = c.Enrollments.Count
        });

    Console.WriteLine("\nCourses with student count:");

    foreach(var course in coursesWithStudentCount)
    {
        Console.WriteLine($"Course: {course.Title}, Enrolled Students: {course.StudentCount}");
    }
}