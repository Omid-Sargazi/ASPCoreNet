class Book 
{
    public string Title { get; set; }
    public string Genre { get; set; }
    public int PublishedYear { get; set; }
}

class Employee
{
    public string Name {get;set;}
    public string Department {get;set;}
}


class Order 
{
    public int OrderId {get;set;}
    public string CustomerName {get;set;}
    public int TotalAmount {get;set;}
}






public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");

    var books = new List<Book>
    {
        new Book { Title = "Book A", Genre = "Fiction", PublishedYear = 2021 },
        new Book { Title = "Book B", Genre = "Fiction", PublishedYear = 2022 },
        new Book { Title = "Book C", Genre = "Science", PublishedYear = 2021 },
        new Book { Title = "Book D", Genre = "Science", PublishedYear = 2022 }
    };

    var employees = new List<Employee> 
{
    new Employee { Name = "John", Department = "HR" },
    new Employee { Name = "Jane", Department = "HR" },
    new Employee { Name = "Doe", Department = "IT" },
    new Employee { Name = "Smith", Department = "IT" }
};


var orders = new List<Order> {
    new Order { OrderId = 1, CustomerName = "Alice", TotalAmount = 100 },
    new Order { OrderId = 2, CustomerName = "Bob", TotalAmount = 200 },
    new Order { OrderId = 3, CustomerName = "Alice", TotalAmount = 150 },
    new Order { OrderId = 4, CustomerName = "Bob", TotalAmount = 300 },
    new Order { OrderId = 5, CustomerName = "Charlie", TotalAmount = 400 }
};



    // group books by Genre and Published Year
    var groupedBooks = books.GroupBy(b=>b.Genre).Select(generGroup=>new {
        Gener = generGroup.Key,
        BooksByYear = generGroup.GroupBy(b=>b.PublishedYear).Select(yearGroup=>new{
            PublishedYear = yearGroup.Key,
            Books = yearGroup.ToList()
        }).ToList()
    });

    
    var employeesByDepartment = employees.GroupBy(e=>e.Department).Select(g=>new{
        Department=g.Key,
        EmployeeCount = g.Count(),
        Employees = g.Select(g=>g.Name)
    }).ToList();

    foreach(var dept in employeesByDepartment)
    {
        Console.WriteLine($"Department: {dept.Department}, Employee Count: {dept.EmployeeCount}");
        foreach(var employee in dept.Employees)
        {
            Console.WriteLine($"Employee: {employee}");
    }
    
    
    }

    
    var ordersByCustomer = orders.GroupBy(o=>o.CustomerName).Select(g=>new{
        CustomerName = g.Key,
        TotalAmount= g.Sum(g=>g.TotalAmount),
        orders = g.Select(o=>new{o.OrderId,o.TotalAmount}).ToList()
    }).ToList();

    
    
    }

}



