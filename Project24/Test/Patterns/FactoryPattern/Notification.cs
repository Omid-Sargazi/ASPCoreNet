namespace Test.Pattern.FactoryPattern
{
    public class Notification
    {
        public void Notify(string message)
        {
            if (type == "Email")
            Console.WriteLine("Sending Email...");
        else if (type == "SMS")
            Console.WriteLine("Sending SMS...");
        else
            Console.WriteLine("Unknown notification type.");
        }
    }
}