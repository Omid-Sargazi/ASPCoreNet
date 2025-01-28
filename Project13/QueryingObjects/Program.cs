using System.Security.Cryptography;
using QueryingObjects.Models;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");

        List<Person> people = new List<Person> {
            new Person {Name = "Alice", Age=25, City="New Yourk"},
            new Person {Name = "Bob", Age=30, City="LA"},
            new Person {Name = "Charlie", Age=35, City="LA"},
            new Person {Name = "David", Age=40, City="Chicago"},
            new Person {Name = "Eve", Age=28, City="LA"}
        };


        var newYorkers = from person in people
                            where person.City == "New Yourk"
                            select person;
        Console.WriteLine("People from NewYork:");
        foreach(var person in newYorkers)
        {
            Console.WriteLine($"{person.Name}, {person.Age}");
        }

        var olderThanThirty = people.Where(person => person.Age>30)
        .OrderBy(person=> person.Name);
        
        Console.WriteLine($"People order than 30 (Sorted by name:)");
        foreach(var person in olderThanThirty)
            Console.WriteLine($"{person.Name}, {person.Age}");

    }
}