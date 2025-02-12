﻿using System.Security.Cryptography;
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


        var nameAndCity = people.Select(person=>new {person.Name, person.City});
        
        Console.WriteLine($"Names and Cities:");
        foreach(var item in nameAndCity)
        {
            Console.WriteLine($"{item.Name},{item.City}");
        }

        var distinctCities = people.Select(person=>person.City).Distinct();

        Console.WriteLine($"Distinct Cities:");
        foreach(var city in distinctCities)
            Console.WriteLine(city);

        var youngAngelenos = people.Where(person => person.City=="LA" && person.Age<30);
        Console.WriteLine($"Young people from LA");

        foreach(var item in youngAngelenos)
        {
            Console.WriteLine(item.Name);
        }
        
        var peopleByCity = people.GroupBy(person => person.City);

        Console.WriteLine($"Peopel Grouped By City:");
        foreach(var group in peopleByCity)
        {
            Console.WriteLine($"City: {group.Key}");

            foreach(var person in group)
            {
                Console.WriteLine($"{person.Name},{person.Age}");
            }
        }


        bool anyChicagoans = people.Any(person => person.City=="Chicago");
        Console.WriteLine($"Are there any peopel from chicago: {anyChicagoans}");

        bool allAdults = people.All(person => person.Age > 20);
        Console.WriteLine($"Are all peopel older than 20");

        var firstAngeleno = people.FirstOrDefault(person => person.City=="LA");
        Console.WriteLine($"First peopel from LA: {firstAngeleno?.Name??"None"}");


        /////////////////////////////////////////////////
         List<PersonWithHobbies> peopleWithHobbies = new List<PersonWithHobbies>
    {
        new PersonWithHobbies {Name="Alice", Hobbies=new List<string>{"Reading", "Swimming"}},
        new PersonWithHobbies {Name="Bob", Hobbies=new List<string>{"Cycling", "Hiking"}}
    };

    var allHobbies = peopleWithHobbies.SelectMany(person => person.Hobbies);
    Console.WriteLine("All Hobbies;");
    foreach(var hobby in allHobbies)
        Console.WriteLine(hobby);

    }
}