using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookstoreManagementSystem.Domain.Interfaces;
using BookstoreManagementSystem.Domain.ValueObjects;

namespace BookstoreManagementSystem.Domain.Entities
{
    public class Customer:IAggregateRoot
    {
        public int Id {get; private set;}
        public string Name {get; private set;}
        public Email Email {get; private set;}
        public List<Order> Orders {get; private set;} = new List<Order>();

        public Customer(string name, Email email)
        {
            if(string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Customer name cannot be empty.");
            Name = name;

            Email = email ?? throw new ArgumentException(nameof(email));
        }

        public void Update(string name, Email email)
        {
            if(string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Customer name cannot be empty.");
            Name = name;
            Email = email ?? throw new ArgumentException(nameof(email));
        }
    }
}