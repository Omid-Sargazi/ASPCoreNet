public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        // Animal dog = new Animal{Name = "Rex"};
        // dog.Eat();
        Dog dog = new Dog{Name = "rex"};
        dog.Eat();
        dog.Bark();
        Cat cat = new Cat{Name = "Luna"};
        cat.Eat();
        cat.Meow();

    }
}