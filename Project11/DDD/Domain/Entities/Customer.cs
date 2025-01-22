using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.ValueObjects;

namespace Domain.Entities
{
    public class Customer
    {
         public Guid Id { get; private set; }
        public string Name { get; private set; }
        public Address Address { get; private set; }
    

    public Customer(Guid id, string name, Address address)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Customer name cannot be empty.");
            }

            Id = id;
            Name = name;
            Address = address;
        }

        public void ChangeAddress(Address newAddress)
        {
            Address = newAddress;
        }
}
}

