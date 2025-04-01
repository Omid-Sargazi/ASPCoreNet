namespace Test.OOP
{
    public class Robot : IWorker
    {
        public void Work() => Console.WriteLine("Robot is working...");
    
    public void Eat() 
    {
        // ❌ Not applicable for Robot!
        throw new NotImplementedException();
    }

    public void Sleep()
    {
        // ❌ Not applicable for Robot!
        throw new NotImplementedException();
    }
    }
}