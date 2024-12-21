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

    // public class Logger
    // {
    //     public void Log(string message)
    //     {
    //         Console.WriteLine(message);
    //     }
    // }


    public class ProductService02
    {
       private readonly ILogger _logger;

       public ProductService02(ILogger logger)
       {
           _logger = logger;
       }

       public void AddProduct(string product)
       {
        _logger.Log($"Product {product} added.");
       }
    }

    public interface ILogger
    {
        void Log(string message);
    }

    public class Logger:ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }


    public class UserService
    {
        private Database _database;

        public UserService()
        {
            _database = new Database();
        }

        public void SaveUser(string user)
        {
            _database.Save(user);
        }
    }


    public class Database
    {
        public void Save(string data)
        {
            Console.WriteLine($"Saving {data} to database.");
        }
    }




    public class UserServiceDI
    {
        private readonly IDatabase _database;

        public UserServiceDI(IDatabase database)
        {
            _database = database;
        }


        public void SaveUser(string user)
        {
            _database.Save(user);
        }
    }

    public interface IDatabase
    {
        void Save(string data);
    }


    public class DatabaseDI : IDatabase
    {
        public void Save(string data)
        {
            Console.WriteLine($"Saving {data} to database.");
        }
    }

}