using LINQASPNET.Models;

public class Program
{
    public static void  Main(string[] args)
    {
        Console.WriteLine("Hello");

        var numbers = new List<int> {1,2,3,4,5,6,7,8,9,10};
        var evenNumbers = numbers.Where(number => number%2 ==0).ToList();

        foreach(var num in evenNumbers)
        {
            Console.WriteLine(string.Join(",",evenNumbers));
        }

        var squaredNumbers = numbers.Select(num => num*num).ToList();
        Console.WriteLine(string.Join(",",squaredNumbers));

        //Filtering and Transforming
         var evenSquares = numbers.Where(num => num%2==0).Select(num => num*num).ToList();
         Console.Write(string.Join(",",evenSquares));

         //Filtering a Custom Object
         var employees = new List<Employee> 
         {
            new Employee {Name="Alice", Age=25},
            new Employee {Name="Bob", Age=35},
            new Employee {Name="Charlie", Age=40}
         };

         var olderEmployee = employees.Where(e => e.Age>30).ToList();
         olderEmployee.ForEach(e =>Console.WriteLine(e.Name));

         var employeeNames = employees.Where(e =>e.Age>30).Select(e => e.Name)
         .ToList();

         Console.WriteLine(string.Join(",",employeeNames));
    }
}