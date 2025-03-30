public class Dog:Animal
{
    public void Bark()
    {
        Console.WriteLine($"{Name} is barking.");
    }
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says barks.");
    }
}