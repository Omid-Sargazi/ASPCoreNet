public class Cat:Animal
{
    public void Meow()
    {
        Console.WriteLine($"{Name} is meowing.");
    }
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says meow.");
    }
}