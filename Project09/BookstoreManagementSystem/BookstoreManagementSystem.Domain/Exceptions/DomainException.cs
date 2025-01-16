using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreManagementSystem.Domain.Exceptions
{
    public abstract class DomainException:Exception
    {
        protected DomainException(string message):base(message){}
    }
}