namespace Test.OOP  
{
    public class Human : IWorkable, IHumanNeeds
{
    public void Work() => Console.WriteLine("Human is working...");
    public void Eat() => Console.WriteLine("Human is eating...");
    public void Sleep() => Console.WriteLine("Human is sleeping...");
}
}