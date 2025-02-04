public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello LINQ");

        var listOfLists = new List<List<int>> 
        {
            new List<int>{1,2,3},
            new List<int> {4,5},
            new List<int> {6}
        };
        var result = listOfLists.SelectMany(list => list).ToList();
        foreach(var i in result)
        {
            Console.WriteLine(i);
        }

        var listOfArray = new List<int[]> 
        {
            new int[] {1,2,3},
            new int[] {4, 5, 6},
            new int[] {7, 8}
        };
        result = listOfArray.SelectMany(array => array).ToList();

        var words = new List<string> {"hello","world"};
        var wordsResults = words.SelectMany(word => word.ToCharArray()).ToList();
        ///////////////////////////////////////////
        ///Flatten a list of strings into characters with index
        var wordsWithIndex = words.SelectMany((word, index) 
        => word.Select(c => new{Char = c, WordIndex = index})).ToList();
        foreach(var i in wordsWithIndex)
        {
            Console.WriteLine(i.Char +i.WordIndex);
        }

        //Flatten a list of objects with nested collections
    

    }
}