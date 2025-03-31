public class ConcreteObserver : IObserver
{
   public void Update(ISubject subject)
    {
        if (subject is Subject concreteSubject)
        {
            Console.WriteLine($"Observer: Reacted to the state change to {concreteSubject.State}");
        }
    }
}