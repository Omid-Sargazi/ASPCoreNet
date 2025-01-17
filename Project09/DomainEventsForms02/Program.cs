using DomainEventsForms02.Entities;
using DomainEventsForms02.Events;

public class UserRegistered
{
    public string UserName { get; }

        public UserRegistered(string userName)
        {
            UserName = userName;
        }
}

class Program
{
    static void Main(string[] args)
    {
        DomainEvents.Register<UserRegistered>(Event=>{
             Console.WriteLine($"Welcome email sent to {Event.UserName}.");
        });

        DomainEvents.Register<UserRegistered>(Event=>{
            Console.WriteLine($"User registration logged: {Event.UserName}.");
        });

        var userName = "JohnDoe";
        Console.WriteLine($"Registering user: {userName}");

        DomainEvents.Raise(new UserRegistered(userName));

        Console.WriteLine("/////////////////////////////////////////////////");

        DomainEvents.Register<OrderPlaced>(Event=>{
                Console.WriteLine($"Payment process started for Order ID: {Event.OrderId}, Customer: {Event.CustomerName}.");

        });

        DomainEvents.Register<OrderPlaced>(Event=>{
            Console.WriteLine($"Warehouse notified for Order ID: {Event.OrderId}.");
        });


        var orderId = 101;
        var customerName = "Jane Doe";
        Console.WriteLine($"Order placed: ID = {orderId}, Customer = {customerName}");

        DomainEvents.Raise(new OrderPlaced(orderId, customerName));
    }
}