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
    }
}