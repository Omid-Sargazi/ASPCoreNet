

using LINQExample;
using LINQExample.Models;
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

            //List Students Without Any Enrollments
            var studentsWithoutEnrollments = context.Students.GroupJoin(context.Enrollments,
                student=>student.StudentId,
                enrollment=>enrollment.StudentId,
                (student,enrollments)=>new{Student=student,Enrollment=enrollments}
            ).Where(g=>!g.Enrollment.Any()).Select(g=>g.Student.Name).ToList();

            //List All Courses Grouped by Instructor
            var coursesByInstructor = context.Instructors.Select(i=>new{
                coursesByInstructor = i.Name,
                Course = i.Courses.Select(c=>c.Title).ToList()
            }).ToList();

            //List All Students and Their Total Courses
            var studentsWithCourseCounts = context.Students.Select(s=>new{
                StudentName = s.Name,
                TotalCourses = s.Enrollments.Count
            }).ToList();

            //List Students Enrolled in a Specific Course
            var studentsInMath = context.Enrollments.Include(e=>e.Student)
            .Include(e=>e.Course)
            .Where(e=>e.Course.Title=="Math 101")
            .ToList();

            //Find the Most Popular Course (By Enrollment Count)
            var mostPopularCourse = context.Courses.Select(c=>new{
                CourseTitle = c.Title,
                StudentCount = c.Enrollments.Count
            }).OrderByDescending(c=>c.StudentCount).FirstOrDefault();

            //List All Courses with Their Students
            var coursesWithStudents = context.Courses.Select(c=>new{
                CourseTitle = c.Title,
                Students = c.Enrollments.Select(e=>e.Student.Name).ToList()
            }).ToList();

            //Find Students Enrolled in a Specific Course
            var studentsInMath101 = context.Enrollments
            .Where(e=>e.Course.Title=="Math 101")
            .Select(e=>e.Student.Name).ToList();
            
            //Find all students enrolled in "Science 102" 

            var studentsEnrolledScience = context.Enrollments.Where(e=>e.Course.Title=="Science 102")
            .Select(e=>new{
                Name=e.Student.Name
            }).ToList();

            //Find the names of students who are enrolled in more than 2 courses
            var studentsEnrolledMoreTwoCourses = context.Students.Where(s=>s.Enrollments.Count>2).Select(e=>new{
                Name = e.Name
            }).ToList();

            //Find the titles of courses that no students are enrolled in
            var coursesWithoutEnrollement = context.Courses.Where(c=>c.Enrollments.Count==0).Select(e=>e.Title).ToList(); 

            //Find the total number of courses each student is enrolled in
            var allCourses = context.Students.Select(s=>new{
                Name=s.Name,
                Count = s.Enrollments.Count
            }).ToList();




        }
    }
