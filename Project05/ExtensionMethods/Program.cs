public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Omid");
        string example = null;

        bool result = example.IsNullOrEmpty();
        Console.WriteLine(result);
    }
}

public static class StringExtensions
{
    public static bool IsNullOrEmpty(this string str)
    {
        return string.IsNullOrEmpty(str);
    }


}


