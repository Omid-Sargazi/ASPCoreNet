using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreManagementSystem.Domain.Exceptions
{
    public class InvalidPriceException : DomainException
    {
        public InvalidPriceException(string message) : base(message)
        {
        }
    }
}