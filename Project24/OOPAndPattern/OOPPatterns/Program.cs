public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Animal dog = new Animal{Name = "Rex"};
        dog.Eat();
    }
}