

using LINQExample;

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


        }
    }
