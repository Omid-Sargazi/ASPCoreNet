using ExtensionMethods.Services;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Omid");
        string example = null;

        bool result = example.omid();
        Console.WriteLine(result);

        string name="omid";
        string revsers = name.ReverseString();
        Console.WriteLine(revsers);

        Console.WriteLine(name.ToTitleCase()+ "TotileCase");

        int number=10;
        Console.WriteLine($"Number is Even:{number.IsEven()}");

        var num = new List<int> {1,2,3,4};
        Console.WriteLine(num.ToCsv());



        var service = new UserService();
        var filteredUsers = service.GetFilteredUsers("Alice",20,30);
        foreach (var user in filteredUsers)
        {
            Console.WriteLine($"{user.Name}, {user.Age}, {user.Email}");
        }

    }
}

public static class StringExtensions
{
    public static bool omid(this string str)
    {
        return string.IsNullOrEmpty(str);
    }
}


public static class StringExtentions02
{
    public static string ReverseString(this string str)
    {
        if(string.IsNullOrEmpty(str)) return str;
        return new string(str.Reverse().ToArray());
    }

    public static bool IsEven(this int number)
    {
        return number %2==0;
    }

    public static string ToTitleCase(this string str)
    {
        if(string.IsNullOrEmpty(str)) return str;
        return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str);
    }
}

public static class ListExtensions
{
    public static string ToCsv<T>(this IEnumerable<T> list, char separator=',')
    {
        return string.Join(separator,list);
    }
}





