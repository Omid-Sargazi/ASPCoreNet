namespace ShoppingCartExample
{
    public class Product
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public string Category { get; private set; }

        public Product(string name, decimal price, string category)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Price = price > 0 ? price : throw new ArgumentException("Price must be greater than zero.");
            Category = category ?? throw new ArgumentNullException(nameof(category));
        }

        public override bool Equals(object? obj)
        {
            return obj is Product product &&
            product.Name == Name &&
            product.Price == Price &&
            product.Category == Category;
            
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Price, Category);
        }

        public override string ToString()
        {
            return $"{Name} ({Category} - ${Price})";
        }
    }


    public class Program
    {
        public static void Main(string[] args)
        {
            var shoppingCart = new HashSet<Product>();

           var product1 = new Product("Laptop", 999.99m, "Electronics");
            var product2 = new Product("Laptop", 999.99m, "Electronics");
            var product3 = new Product("Headphones", 199.99m, "Electronics");
            var product4 = new Product("Laptop", 899.99m, "Electronics"); // Different price

            shoppingCart.Add(product1);
            shoppingCart.Add(product2);
            shoppingCart.Add(product3);
            shoppingCart.Add(product4);

             Console.WriteLine("Shopping Cart:");
            foreach (var product in shoppingCart)
            {
                Console.WriteLine(product);
            }

        }
    }


}