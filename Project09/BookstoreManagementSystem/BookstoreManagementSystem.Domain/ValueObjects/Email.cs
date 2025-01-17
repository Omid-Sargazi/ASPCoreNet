using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreManagementSystem.Domain.ValueObjects
{
    public class Email
    {
        public string Address {get; private set;}

        public Email(string address)
        {
            if(string.IsNullOrWhiteSpace(address) || !address.Contains("@"))
                throw new ArgumentException("Invalid email address.");
            
            Address = address;
        }

        public override string ToString()
        {
            return Address;
        }
       
    }
}