using System.Net;
using ComplexLINQ;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello LINQ");

        var listOfLists = new List<List<int>>
        {
            new List<int> {1, 2, 3,},
            new List<int> {4, 5, 6},
            new List<int> {7, 8, 9}
        };

        var result = listOfLists.SelectMany(list => list).ToList();
        foreach(var num in result)
        {
            Console.WriteLine(num);
        }

        //Flatten a list of arrays
        var listOfArray = new List<int[]>
        {
            new int[] {1, 2, 3},
            new int[] {4, 5, 6},
            new int[] {7, 8, 9}
        };
        
        var OneList = listOfArray.SelectMany(arr => arr).ToList();
        Console.WriteLine("Array into list with selectmany");
        foreach(int num in OneList)
        {
            Console.WriteLine(num);
        }

        //Flatten a list of string into characters
        var words = new List<string>{"Omid","Sargazi"};
        var WordsOfString = words.SelectMany(str => str).ToList();
        foreach(var w in WordsOfString)
        {
            Console.WriteLine(w);
        }

        //Flatten a list of strings into characters with index
        var WordsAndIndex = words.SelectMany((word, index)=> word.Select(c => new {Char = c, WordIndex=index})).ToList();

        //Flatten a list of objects with nested collections
        var peopel = new List<Person>
        {
            new Person { Name = "John", Pets = new List<string> { "Dog", "Cat" } },
            new Person { Name = "Jane", Pets = new List<string> { "Fish" } }
        };

        var resultsOfPeopel = peopel.SelectMany(p => p.Pets,(p, pets)=> new {p.Name, Pet = pets}).ToList();
        foreach(var item in resultsOfPeopel)
        {
            Console.WriteLine(item.Name+" " + item.Pet);
        }

       
    }    
}