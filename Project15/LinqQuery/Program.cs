using LinqQuery.Models;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");

        var students = new List<Student>
        {
            new Student{StudentId = 1, Name = "Alice"},
            new Student { StudentId = 2, Name = "Bob" },
             new Student { StudentId = 3, Name = "Charlie" }
        };

        var courses = new List<Course>
            {
            new Course { CourseId = 101, Title = "Mathematics" },
            new Course { CourseId = 102, Title = "Physics" },
            new Course { CourseId = 103, Title = "Chemistry" }
            };

            var enrollments = new List<Enrollment>
            {
                new Enrollment { EnrollmentId = 1, StudentId = 1, CourseId = 101 },
                new Enrollment { EnrollmentId = 2, StudentId = 1, CourseId = 102 },
                new Enrollment { EnrollmentId = 3, StudentId = 2, CourseId = 101 },
                new Enrollment { EnrollmentId = 4, StudentId = 3, CourseId = 103 }
            };


          var studentCourses = enrollments
          .Join(students,e=>e.StudentId,s=>s.StudentId,(e,s)=>new {e,s})
          .Join(courses,es=>es.e.CourseId,c=>c.CourseId,(es,c)=>new{
            StudentName = es.s.StudentId,
            CourseTitle = c.Title,
          }).ToList();

          foreach(var item in studentCourses)
          {
            Console.WriteLine($"Student:{item.StudentName},enrolled in:{item.CourseTitle}");
          }

          //////////////////////////////////
          var employees = new List<Employee> 
          {
            new Employee { EmployeeId = 1, Name = "John", DepartmentId = 101 },
            new Employee { EmployeeId = 2, Name = "Jane", DepartmentId = 102 },
            new Employee { EmployeeId = 3, Name = "Mike", DepartmentId = 101 },
            new Employee { EmployeeId = 4, Name = "Sara", DepartmentId = 103 }
          };

          var departments = new List<Department> 
          {
            new Department { DepartmentId = 101, DepartmentName = "HR" },
            new Department { DepartmentId = 102, DepartmentName = "IT" },
            new Department { DepartmentId = 103, DepartmentName = "Finance" }
          };

          var employeeDetails = employees
          .Join(departments,e=>e.DepartmentId, d=>d.DepartmentId,(e,d)=>new{
            EmployeeName = e.Name,
            DepartmentName = d.DepartmentName
          });

          Console.WriteLine("display each employee's name along with their department name.");
          foreach(var item in employeeDetails)
          {
            Console.WriteLine($"Employee:{item.EmployeeName}, Departemen:{item.DepartmentName}");
          }

          Console.WriteLine("New///////////////////////////////////Query");
          var products = new List<Product>
          {
            new Product{ProductId = 1, ProductName = "Laptop", CategoryId = 1, Price = 1200.00m},
            new Product {ProductId = 2, ProductName = "Samrtphone", CategoryId = 1, Price = 800.00m},
            new Product {ProductId = 3, ProductName = "tablet", CategoryId = 1, Price = 500.00m},
            new Product { ProductId = 4, ProductName = "Desk Chair", CategoryId = 2, Price = 150.00m },
            new Product { ProductId = 5, ProductName = "Office Desk", CategoryId = 2, Price = 300.00m }
          };

          var categories = new List<Category> 
          {
            new Category { CategoryId = 1, CategoryName = "Electronics" },
            new Category { CategoryId = 2, CategoryName = "Furniture" }
          };

          var productDetails = products
          .Join(categories,p=>p.CategoryId,c=>c.CategoryId,(p,c)=>new{

                ProductName = p.ProductName,
                categoryName = c.CategoryName

          }).ToList();


          Console.WriteLine("Product name and product");

          
          foreach(var item in productDetails)
          {
            Console.WriteLine($"Product Name:{item.ProductName}, category name:{item.categoryName}");
          }
    }
}