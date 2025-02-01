using PrototypePatternExample.PrototypePerson;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(args);

        Address address = new Address("1234 Elm St", "Omaha");
        Person original = new Person("Hohn Doe", 25, address);

        Person shallowCopy = original.shallowCopy();

        Person deepCopy = original.DeepCopy();

        Console.WriteLine("Before modifying the original:");
        Console.WriteLine("Original:    " + original);
        Console.WriteLine("Shallow Copy:" + shallowCopy);
        Console.WriteLine("Deep Copy:   " + deepCopy);

        original.Address.Street = "456 BroadWay";
        Console.WriteLine("\nAfter modifying the original's address:");
        Console.WriteLine("Original:    " + original);
        Console.WriteLine("Shallow Copy:" + shallowCopy);
        Console.WriteLine("Deep Copy:   " + deepCopy);

    }
}