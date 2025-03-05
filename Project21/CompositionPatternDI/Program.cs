using CompositionPatternDI.Interfaces;

public class Porgram
{
    public static void Main(string[] args)
    {
        INotification notification = CompositionRoot.CreateNotificationService();
        notification.Notify("Welcome to our service", NotificationType.Email);
    }
}