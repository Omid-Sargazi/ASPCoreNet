

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


        }
    }
