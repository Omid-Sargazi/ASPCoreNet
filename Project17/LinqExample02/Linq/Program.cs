using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("hello");
        Console.WriteLine("Omid");


    var departments = new List<Department>
    {
        new Department { Id = 1, Name = "HR", Budget = 50000 },
        new Department { Id = 2, Name = "IT", Budget = 100000 },
        new Department { Id = 3, Name = "Sales", Budget = 75000 },
        new Department { Id = 4, Name = "Marketing", Budget = 60000 } // No employees
    };

    var employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Alice", Role = "Manager", Salary = 60000, DepartmentId = 1 },
            new Employee { Id = 2, Name = "Bob", Role = "Recruiter", Salary = 50000, DepartmentId = 1 },
            new Employee { Id = 3, Name = "Charlie", Role = "Developer", Salary = 80000, DepartmentId = 2 },
            new Employee { Id = 4, Name = "Dana", Role = "Developer", Salary = 75000, DepartmentId = 2 },
            new Employee { Id = 5, Name = "Eve", Role = "Sales Rep", Salary = 45000, DepartmentId = 3 }
        };


        var allDepts = departments.Select(d => d);
        //Filter Departments by Budget
        var highBudgetDepts = departments.Where(d => d.Budget > 70000);
        foreach (var item in highBudgetDepts)
        {
            Console.WriteLine(item.Name);    
        }

        //Order Employees by Salary (Descending)
        var sortedEmployees = employees.OrderByDescending(e => e.Salary);
        //Total Salary Across All Employees
        var totalSalary = employees.Sum(e => e.Salary);

        Console.WriteLine(totalSalary);

        var maxBudget = departments.Max(d => d.Budget);
        Console.WriteLine("Maximum Budget: "+ maxBudget);

        
    }
}