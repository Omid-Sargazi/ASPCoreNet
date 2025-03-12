// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using Day03CSharp.Models;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int[] numbers = [10, 20, 30, 40, 50];

        Console.WriteLine($" first number is{numbers[0]} ");
        Console.WriteLine($"end of number is {numbers[^1]}");
        Console.WriteLine($"lenght of the list is {numbers.Length}");

        People people = new People("Omid",42);
        people.DisplayInfo();

        int sum = 0;
        for(int i=0; i<= numbers.Length-1; i++)
        {
            sum +=numbers[i];
        }

        Console.WriteLine($"sum of array is {sum}");

        var summ = numbers.Sum();
        Console.WriteLine($"the result with idioums is {summ}");

        string? name = null;
        Console.WriteLine(name != null ? name.Length.ToString() : "No name");

        List<string> names = new List<string>();
        names.Add("omid");
        names.Add("saeed");
        names.Add("vahid");
        names.Add("vah");
        names.Add("va");
        foreach(var item in names)
        {
            if(item.Length>3)
                Console.WriteLine(item);
        }

        var greaterThanThree = names.Where(name => name.Length> 3).ToList();
        foreach(var item in greaterThanThree)
        {
            Console.WriteLine(item);
        }
    }
}


