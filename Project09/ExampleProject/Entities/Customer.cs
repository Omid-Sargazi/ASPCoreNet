using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleProject.Entities
{
    public class Customer
    {
        public Guid Id {get; protected set;}
        public string Name {get; protected set;}
        public string Email {get; protected set;}


        public Customer(string name, string email)
        {
            if(string.IsNullOrWhiteSpace(name))
                throw new Exception("Name cannot be empty.");
            if(string.IsNullOrWhiteSpace(email))
                throw new Exception("Email is required.");
            Id = Guid.NewGuid();
            Name = name;
            Email= email;
        }
    }
}