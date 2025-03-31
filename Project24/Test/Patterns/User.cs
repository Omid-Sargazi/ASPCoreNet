namespace Test.Patterns
{
public class User:IObserver
{
    private string _name;

    public User(string name)
    {
        _name = name;
    }

    public void Update(string message)
    {
        Console.WriteLine($"{_name} received message: {message}");
    }
}

}