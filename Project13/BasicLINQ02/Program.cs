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

    }
}