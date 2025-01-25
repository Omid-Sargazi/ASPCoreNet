using FactoryPattern.Notification.Factory;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Factory Pattern");

        NotificationFactory notification = new CreateEmailNotification();
        notification.Notify("This is an email notification");
        notification = new CreateSMSNotification();
        notification.Notify("This is an SMS notification");
    }
}