using ShallowCopy.ShalowCopy;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");

        Person person1 = new Person{Name="Omid", Address=new Address{City="New York"}};
        Person person2 = person1.ShalowCopy();

        person2.Name = "John";
        person2.Address.City = "LA";

        Console.WriteLine(person1.Name);
        Console.WriteLine(person2.Name);
    }
}