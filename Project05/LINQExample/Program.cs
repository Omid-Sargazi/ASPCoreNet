

using LINQExample;
using Microsoft.EntityFrameworkCore;

class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var context = new SchoolContext();

            //get all students
            var students = context.Students.ToList();
            foreach (var student in students)
            {
                Console.WriteLine($"Student: {student.Name}");
            }


            Console.WriteLine("---- Courses and Instructors ----");
            var courses = context.Courses.Include(c=>c.Instructor).ToList();
            foreach(var course in courses)
            {
                Console.WriteLine($"Course: {course.Title} - Instructor: {course.Instructor.Name}");
            }


            Console.WriteLine("---- Students in Math 101 ----");
            var mathStudents = context.Enrollments.Include(e=>e.Student)
            .Include(e=>e.Course)
            .Where(e=>e.Course.Title=="Math 101")
            .Select(e=>e.Student.Name).ToList();

            foreach (var name in mathStudents)
            {
                 Console.WriteLine($"Student: {name}");
            }

            //List all courses with student counts
            var courseStudentCounts = context.Courses.Select(c=>new{
                c.Title,
                StudentCount = c.Enrollments.Count
            }).ToList();

        }
    }
