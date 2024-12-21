using System;

namespace DIAndIOC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ProductService p1 = new ProductService();
            p1.AddProduct("Salam.....");
        }
    }


    public class ProductService
    {
        private Logger _logger;

        public ProductService()
        {
            _logger=new Logger();
        }

        public void AddProduct(string product)
        {
            _logger.Log($"Product {product} added.");
        }
    }

    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}