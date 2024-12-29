

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
            

            //List instructors with their courses
            var instructorCourses = context.Instructors.Select(i=>new{
                i.Name,
                Courses=i.Courses.Select(c=>c.Title).ToList()
            }).ToList();

            //List students and their enrolled courses
            var studentCourses = context.Students.Select(s=>new {
                s.Name,
                Courses = s.Enrollments.Select(e=>e.Course.Title).ToList()
            }).ToList();

            //List All Courses with No Enrollments
           var coursesWithoutStudents = context.Courses.GroupJoin(context.Enrollments,
            course =>course.CourseId,
            enrollement=>enrollement.CourseId,
            (course,enrollments)=>new{Course=course,Enrollments=enrollments})
            .Where(g=>!g.Enrollments.Any())
            .Select(g=>g.Course.Title).ToList();

            //List All Students with Their Enrolled Courses
            var StudentCourses = context.Students.Select(s=>new{
                StudentName = s.Name,
                EnrolledCourses = s.Enrollments.Select(e=>e.Course.Title).ToList()
            }).ToList();

            foreach (var student in StudentCourses)
            {
                Console.WriteLine($"Student: {student.StudentName}");
                foreach(var course in student.EnrolledCourses)
                {
                    Console.WriteLine($"  Enrolled in: {course}");
                }
            }

            //Count Total Students Per Course
            var CourseStudentCounts = context.Courses.Select(c=>new{
                CourseTitle =  c.Title,
                StudentCount = c.Enrollments.Count,
            }).ToList();

            //List Instructors with the Number of Courses They Teach
            var InstructorCourses = context.Instructors.Select(i=>new{
                InstructorName = i.Name,
                CourseCount = i.Courses.Count
            }).ToList();



        }
    }
