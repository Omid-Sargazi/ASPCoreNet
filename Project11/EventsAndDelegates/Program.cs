using EventsAndDelegates;

public class Program
{
    public delegate void Notify(string message);
    public static void Main(string[] args)
    {
        // Notify notification = ShowMessage;
        // Console.WriteLine("Hello World!");
        // notification("Hello, this is a simple delegate example!");


        var dispatch = new SimpleDispatcher();
        
        dispatch.OnMessage += msg=> Console.WriteLine($"Recieved:{msg}");
        dispatch.Dispatch("Hello Event Dispatcher!");
    }

    static void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
}