using BasicLINQ02.Models;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5,6,7,8,9,10 };

        var evenNumbers = from num in numbers
                            where num%2==0
                            select num;
        
        foreach(var num in evenNumbers)
            Console.WriteLine("Even Numbers :"+num);

        var greaterThanFive = numbers.Where(num => num >=5);
        Console.WriteLine("gretaer than five:");
        foreach(var num in greaterThanFive)
            Console.WriteLine(num);

        //Sorting with OrderBy
        var sortedNumbers = numbers.OrderBy(num => num);
        Console.WriteLine("Sorted numbers:");
        foreach(var num in sortedNumbers)
            Console.WriteLine(num);

        //Sorting with OrderByDescending
        var sortedDescending = numbers.OrderByDescending(num => num);
        Console.WriteLine("Odrer by desending.");
        foreach(var num in sortedDescending)
            Console.WriteLine(num);

        //Selecting Specific Properties
        var squares = numbers.Select(num => num*num);
        Console.WriteLine("Squares of numbers:");
        foreach(var num in squares)
            Console.WriteLine(num);

        //Combining Where and Select
        var evenSquares = numbers.Where(num => num%2==0).Select(num => num*num);
        //Using First and FirstOrDefault
        var firstEven = numbers.Where(num=>num%2==0).First();
        Console.WriteLine("First even is: "+ firstEven);

        //firstGreaterThanTen
        var firstGreaterThanTen = numbers.FirstOrDefault(num => num>10);
        //Using Any and All
        bool anyGreatenThanTen = numbers.Any(num => num>10);

        bool allGreaterThanZero = numbers.All(num => num >0);
        
        //Aggregating Data with Sum, Average, Min, and Max csharp
        var sum = numbers.Sum(num => num);
        Console.WriteLine("Sum is : "+ sum);

        double average = numbers.Average();
        int min = numbers.Min();
        int max=  numbers.Max();
        // Using Distinct to Remove Duplicates

        var numbersWithDoublicates  = new List<int>{1,1,2,2,3,3,4,5,5,6,7,8};
        var distinctNumbers = numbersWithDoublicates.Distinct();

        List<Person> peopel = new List<Person>
        {
            new Person {Name = "Alice", Age = 25, City = "New York" },
            new Person { Name = "Bob", Age = 30, City = "Los Angeles" },
            new Person { Name = "Charlie", Age = 35, City = "New York" },
            new Person { Name = "David", Age = 40, City = "Chicago" },
            new Person { Name = "Eve", Age = 28, City = "Los Angeles" }
        };

        var newYorkers = from person in peopel
                        where person.City == "New York"
                        select person;
        Console.WriteLine("People from NewYork:");
        foreach(var person in newYorkers)
            Console.WriteLine(person.Name);



    }
}