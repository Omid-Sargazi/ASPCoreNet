using ProxyPattern;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");
        IImage image = new ProxyClass("1.png");
        image.Display();
        image.Display();
        
        image.Display();
    }
}