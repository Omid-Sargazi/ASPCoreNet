public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");

        List<int> numbers = new List<int> {1,2,3,4,5,6,7,8,9,10};

        var evenNumbers = from num in numbers
                            where num %2 == 0
                            select num;
        Console.WriteLine("Even numbers:");

        foreach(var num in evenNumbers)
            Console.WriteLine(num);


        var greaterThanFive = numbers.Where(num => num>=5);

        Console.WriteLine("Numbers greater than five:");
        foreach(var num in greaterThanFive )
            Console.WriteLine(num);

        
        var sortedNumbers = numbers.OrderBy(num => num);

        Console.WriteLine("Sorted Numbers");
        foreach(var num in sortedNumbers)
            
            Console.WriteLine(num);

            var sortedDescending = numbers.OrderByDescending(num => num);
            Console.WriteLine("Soreted Numbers (Descending): ");

            foreach(var num in sortedDescending)
            {
                Console.WriteLine(num);
            }


            var squares = numbers.Select(num => num*num);
            Console.WriteLine("Squares of Numbers:");

            foreach(var num in squares)
            {
                Console.WriteLine(num);
            }

            var evenSquares = numbers.Select(num => num*num)
            .Where(num => num%2==0);
            Console.WriteLine("Squares of even numbers");
            foreach(var num in evenSquares)
            {
                Console.WriteLine(num);
            }
    }
}