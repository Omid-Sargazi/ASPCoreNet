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

            Console.WriteLine("//////////////");

            var price1 = new Money(50,"USD");
            var price2 = new Money(50, "USD");
            var totalPrice = price1.Add(price2);

            Console.WriteLine($"Total Price: {totalPrice.Amount}, {totalPrice.Currency}");
            Console.WriteLine($"{price1.Equals(price2)}");
            Console.WriteLine("//////////////");
            var productId = Guid.NewGuid();
            var product = new Product(productId, "Laptop", new Money(1000, "USD"));
            product.UpdatePrice(new Money(1200,"Pound"));

            Console.WriteLine($"Updated Price:{product.Price.Amount}, {product.Price.Currency}");
    }
}