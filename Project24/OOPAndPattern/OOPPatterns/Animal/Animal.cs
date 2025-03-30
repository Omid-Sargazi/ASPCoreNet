public class Animal
{
    public string Name {get; set;}
    public void Eat()
    {
        Console.WriteLine($"{Name} is eating.");
    }
    public virtual void MakeSound()
    {
        Console.WriteLine($"{Name} makes a generic sound.");
    }
}