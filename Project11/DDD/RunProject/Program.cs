using Domain.Entities;
using Domain.ValueObjects;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("hello");
        
            var address = new Address("123 Main St", "New York", "10001");
            var customer = new Customer(Guid.NewGuid(),"Omid sa", address);

            Console.WriteLine($"Customer: {customer.Name}, Address:{customer.Address.City}, {customer.Address.Street}");

            var newAddress = new Address("456 Elm St", "LA", "90001");
            customer.ChangeAddress(newAddress);
            Console.WriteLine($"Updated Address: {customer.Address.Street}, {customer.Address.City}");
    }
}