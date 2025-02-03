using LinqQuery.LibrarySystem;
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

          Console.WriteLine("************Filtering and Sorting*****************");
          var filteredProductDetails = products
          .Join(categories,p=>p.CategoryId, c=>c.CategoryId,(p,c)=>new {
            ProductName = p.ProductName,
            categoryName = c.CategoryName,
            Price = p.Price
          }).Where(p=>p.Price>400).OrderBy(p=>p.categoryName).ToList();
          Console.WriteLine("Filtering and Sorting");
          foreach(var item in filteredProductDetails)
          {
            Console.WriteLine($"{item.ProductName},{item.categoryName},{item.Price}");
          }

          Console.WriteLine("**********Library Query********");
          var books = new List<Book> 
          {
            new Book{BookId = 1, Title = "the great gatsby", AuthorId = 1, PublisherId = 101},
            new Book {BookId = 2, Title = "To Kill a Mockingbird", AuthorId = 2, PublisherId = 102},
             new Book { BookId = 3, Title = "1984", AuthorId = 3, PublisherId = 103 },
            new Book { BookId = 4, Title = "Pride and Prejudice", AuthorId = 4, PublisherId = 101 }
          };

          var authors = new List<Author>
            {
                new Author { AuthorId = 1, AuthorName = "F. Scott Fitzgerald" },
                new Author { AuthorId = 2, AuthorName = "Harper Lee" },
                new Author { AuthorId = 3, AuthorName = "George Orwell" },
                new Author { AuthorId = 4, AuthorName = "Jane Austen" }
            };

            var publishers = new List<Publisher>
            {
                new Publisher { PublisherId = 101, PublisherName = "Penguin Books" },
                new Publisher { PublisherId = 102, PublisherName = "HarperCollins" },
                new Publisher { PublisherId = 103, PublisherName = "Secker & Warburg" }
            };


            var bookDetails = books
            .Join(publishers,b=>b.PublisherId,p=>p.PublisherId,(b,p)=>new{b,p})
            .Join(authors,bp=>bp.b.AuthorId,a=>a.AuthorId,(bp,a)=>new{
                BookName = bp.b.Title,
                AuthorName = a.AuthorName,
                PublisherName = bp.p.PublisherName
            }).ToList();
            Console.WriteLine("Details books");
            foreach(var item in bookDetails)
            {
                Console.WriteLine($"bookName:{item.BookName}, Autorname:{item.AuthorName} ,publishename: {item.PublisherName}");
            }

            var penguinBooks = books
            .Join(publishers,b => b.PublisherId, p => p.PublisherId,(b,p)=>new {
                BookName = b.Title,
                PublisherName = p.PublisherName
            }).Where(p => p.PublisherName=="Penguin Books").ToList();

            Console.WriteLine("Penguin Books");
            foreach(var item in penguinBooks)
            {
                Console.WriteLine($"Name:{item.BookName}, publisher:{item.PublisherName}");
            }
            /////////////////////////////////////////////////
        var movies = new List<Movie>
        {
            new Movie { MovieId = 1, Title = "Inception", DirectorId = 1, GenreId = 1, ReleaseYear = 2010 },
            new Movie { MovieId = 2, Title = "The Dark Knight", DirectorId = 1, GenreId = 2, ReleaseYear = 2008 },
            new Movie { MovieId = 3, Title = "Interstellar", DirectorId = 1, GenreId = 3, ReleaseYear = 2014 },
            new Movie { MovieId = 4, Title = "The Social Network", DirectorId = 2, GenreId = 4, ReleaseYear = 2010 },
            new Movie { MovieId = 5, Title = "Fight Club", DirectorId = 3, GenreId = 5, ReleaseYear = 1999 }
        };

        var directors = new List<Director>
        {
            new Director { DirectorId = 1, DirectorName = "Christopher Nolan" },
            new Director { DirectorId = 2, DirectorName = "David Fincher" },
            new Director { DirectorId = 3, DirectorName = "David Fincher" } // Note: Same director for multiple movies
        };

        var genres = new List<Genre>
        {
            new Genre { GenreId = 1, GenreName = "Sci-Fi" },
            new Genre { GenreId = 2, GenreName = "Action" },
            new Genre { GenreId = 3, GenreName = "Adventure" },
            new Genre { GenreId = 4, GenreName = "Drama" },
            new Genre { GenreId = 5, GenreName = "Thriller" }
        };

        var movieDetails = movies
        .Join(directors, m=>m.DirectorId, d => d.DirectorId,(m,d)=>new {m,d})
        .Join(genres,md=>md.m.GenreId, g=>g.GenreId,(md, g)=>new{
            MovieName = md.m.Title,
            DirectorName = md.d.DirectorName,
            genereName = g.GenreName
        }).ToList();

        Console.WriteLine("Movie details");
        foreach(var item in movieDetails)
        {
            Console.WriteLine($"Movie:{item.MovieName},  Director:{item.DirectorName}, genereName:{item.genereName}");
        }

        //////////////////////////////////////////////////////
         var orders = new List<Order>
            {
                new Order { OrderId = 1, CustomerId = 101, ProductId = 1, Quantity = 2, OrderDate = new DateTime(2023, 10, 1) },
                new Order { OrderId = 2, CustomerId = 102, ProductId = 2, Quantity = 1, OrderDate = new DateTime(2023, 10, 2) },
                new Order { OrderId = 3, CustomerId = 103, ProductId = 3, Quantity = 3, OrderDate = new DateTime(2023, 10, 3) },
                new Order { OrderId = 4, CustomerId = 101, ProductId = 2, Quantity = 1, OrderDate = new DateTime(2023, 10, 4) }
            };

            var customers = new List<Customer>
            {
                new Customer { CustomerId = 101, CustomerName = "Alice", Email = "alice@example.com" },
                new Customer { CustomerId = 102, CustomerName = "Bob", Email = "bob@example.com" },
                new Customer { CustomerId = 103, CustomerName = "Charlie", Email = "charlie@example.com" }
            };

            var productsOrder = new List<ProductOrder>
            {
                new ProductOrder { ProductId = 1, ProductName = "Laptop", Price = 1200.00m },
                new ProductOrder { ProductId = 2, ProductName = "Smartphone", Price = 800.00m },
                new ProductOrder { ProductId = 3, ProductName = "Tablet", Price = 500.00m }
            };

            var orderDetails = orders
            .Join(customers, o=> o.CustomerId, c=>c.CustomerId,(o,c)=>new{o,c})
            .Join(productsOrder,oc=>oc.o.ProductId, p=>p.ProductId,(oc, p)=>new{
                orderId = oc.o.OrderId,
                customerName = oc.c.CustomerName,
                productName = p.ProductName,
                quantity = oc.o.Quantity,
                TotalPrice = oc.o.Quantity * p.Price,
                OrderDate = oc.o.OrderDate,
            }).ToList();

            Console.WriteLine("******************Librray System*****************");
            var booksLib = new List<BookLib>
            {
                    new BookLib { BookId = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald" },
                    new BookLib { BookId = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee" },
                    new BookLib { BookId = 3, Title = "1984", Author = "George Orwell" }
            };

            var studentsLib = new List<StudentLib>
                {
                    new StudentLib { StudentId = 101, Name = "Alice", Email = "alice@example.com" },
                    new StudentLib { StudentId = 102, Name = "Bob", Email = "bob@example.com" }
                };
            var borrowRecords = new List<BorrowRecord>
            {
                new BorrowRecord { BorrowId = 1, BookId = 1, StudentId = 101, BorrowDate = new DateTime(2023, 9, 1), DueDate = new DateTime(2023, 9, 15), ReturnDate = new DateTime(2023, 9, 14) },
                new BorrowRecord { BorrowId = 2, BookId = 2, StudentId = 102, BorrowDate = new DateTime(2023, 9, 5), DueDate = new DateTime(2023, 9, 19), ReturnDate = null }, // Not yet returned
                new BorrowRecord { BorrowId = 3, BookId = 3, StudentId = 101, BorrowDate = new DateTime(2023, 9, 10), DueDate = new DateTime(2023, 9, 24), ReturnDate = new DateTime(2023, 9, 25) } // Returned late
            };

            var borrowDetails = borrowRecords
            .Join(booksLib,br => br.BookId, b=>b.BookId,(br, b)=>new{br, b})
            .Join(studentsLib,brb=>brb.br.StudentId, s =>s.StudentId,(brb,s)=>new{
                StudentName = s.Name,
                BookTitle = brb.b.Title,
                BorrowDate = brb.br.BorrowDate,
                DueDate = brb.br.DueDate,
                ReturnDate = brb.br.ReturnDate,

            });
    }
}