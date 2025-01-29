using ShallowCopy.DeepCopy;
using ShallowCopy.ShalowCopy;
using ShallowCopy.ShalowCopy02;

public class Program
{
    public static void Main(string[] args)
    {
        // Console.WriteLine("Hello");

        // Person person1 = new Person{Name="Omid", Address=new Address{City="New York"}};
        // Person person2 = person1.ShalowCopy();

        // person2.Name = "John";
        // person2.Address.City = "LA";

        // Console.WriteLine(person1.Name);
        // Console.WriteLine(person2.Name);


        // Console.WriteLine("//////////////////////");

        // DeepPerson deepPerson01 = new DeepPerson{Name = "Omid", deepAddress = new DeepAddress{City="New york"}};
        // DeepPerson deepPerson02 = deepPerson01.DeepCopy();

        // deepPerson02.Name = "John";
        // deepPerson02.deepAddress.City = "LA";

        // Console.WriteLine("DeepCopy");
        // Console.WriteLine(deepPerson01.Name);
        // Console.WriteLine(deepPerson02.Name);

        ShallowPerson person01 = new ShallowPerson {Name = "Omid", ShallowAddress = new ShallowAddress {City = "New York"}};
        ShallowPerson person02 = person01.ShallowCopy();

        person02.Name = "Saeed";
        person02.ShallowAddress.City = "Lux";

        Console.WriteLine($"Shallow Copy main Objetc is:  {person01.Name},{person01.ShallowAddress.City}");
        Console.WriteLine($"Shallow Copy of object is:  {person02.Name},{person02.ShallowAddress.City}");
    }
}