﻿using LINQExample.Models;
public class Program
{
    public static void Main(string[] args)
    {
        var customers = new List<Customer>
        {
             new Customer { Id = 1, Name = "Alice", Email = "alice@email.com", Age = 25 },
            new Customer { Id = 2, Name = "Bob", Email = "bob@email.com", Age = 30 },
            new Customer { Id = 3, Name = "Charlie", Email = "charlie@email.com", Age = 22 },
            new Customer { Id = 4, Name = "Dana", Email = "dana@email.com", Age = 28 }
        };

        var orders = new List<Order>
        {
            new Order { OrderId = 101, CustomerId = 1, Amount = 100, OrderDate = new DateTime(2023, 1, 15) },
            new Order { OrderId = 102, CustomerId = 2, Amount = 150, OrderDate = new DateTime(2023, 2, 20) },
            new Order { OrderId = 103, CustomerId = 1, Amount = 300, OrderDate = new DateTime(2023, 3, 5) },
            new Order { OrderId = 104, CustomerId = 3, Amount = 75, OrderDate = new DateTime(2023, 3, 10) },
            new Order { OrderId = 105, CustomerId = 4, Amount = 200, OrderDate = new DateTime(2023, 4, 1) }
        };


        ////////////////////LINQ/////////////////////////////////////
        
        var allCustomers = customers.Select(c =>c);
        foreach(var item in allCustomers)
        {
            Console.WriteLine(item.Name);
        }

        //Where Filter
        var customersOver25 = customers.Where(c => c.Age > 25);
        
        foreach(var item in customersOver25)
        {
            Console.WriteLine(item);
        }

        //OrderBy
        var orderedCustomers = customers.OrderBy(c => c.Age);
        foreach(var item in orderedCustomers)
        {
            Console.WriteLine(item.Age);
        }

        //Where + OrderBy
        var result = customers.Where(c => c.Age > 25)
        .OrderByDescending(c => c.Age);
        Console.WriteLine("OderBy&Decending");
        foreach(var item in result)
        {
            Console.WriteLine(item.Age);
        }
        //Specific Field by Where
        var customerEmails = customers.Select(c => c.Email);
        Console.WriteLine("Specific Field");
        foreach(var item in customerEmails)
        {
            Console.WriteLine(item);
        }
    }
}