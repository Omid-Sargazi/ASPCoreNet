﻿using System;

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



    public class OrderService
    {
        private readonly PaymentGateway _paymentGateway;

        public OrderService()
        {
            _paymentGateway = new PaymentGateway();
        }

        public void ProcessOrder()
        {
            _paymentGateway.ProcessPayment();   
        }
    }


    public class PaymentGateway
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Payment processed.");
        }
    }

    public class OrderServiceDI
    {
        private readonly IPaymentGateway _paymentGateway;

        public OrderServiceDI(IPaymentGateway paymentGateway)
        {
            _paymentGateway = paymentGateway;
        }

        public void ProcessOrder()
        {
            _paymentGateway.ProcessPayment();
        }
    }



    public interface IPaymentGateway
    {
        void ProcessPayment();
    }

    public class PaymentGatewayDI:IPaymentGateway
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Payment processed.");
        }
    }


    public class NotificationService
    {
        private EmailService _emailService;

        public NotificationService()
        {
            _emailService=new EmailService();
        }

        public void Notify(string message)
        {
            _emailService.SendEmail(message);
        }
    }


    public class EmailService
    {
        public void SendEmail(string message)
        {
            Console.WriteLine($"Email sent: {message}");
        }
    }


    public class NotificationServiceDI
    {
        private readonly IEmailService _emailService;
        
        public NotificationServiceDI(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public void Notify(string message)
        {
            _emailService.SendEmail(message);
        }
    }

    public interface IEmailService
    {
        void SendEmail(string message);
    }

    public class EmailServiceDI:IEmailService
    {
        public void SendEmail(string message)
        {
            Console.WriteLine($"Email sent: {message}");
        }
    }


    public interface INotificationService
    {
        public void SendNotification();
    }

    public class EmailNotification:INotificationService
    {
        public void SendNotification()
        {
            Console.WriteLine("Email notification sent.");
        }
    }

    public class SmsNotification:INotificationService
    {
        public void SendNotification()
        {
            Console.WriteLine("SMS notification sent.");
        }
    }


    public class NotificationManager
    {
        private readonly INotificationService _notificationService;

        public NotificationManager(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public void SendNotification()
        {
            _notificationService.SendNotification();
        }
    }

}