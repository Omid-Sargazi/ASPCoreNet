using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Common
{
    public interface IDomainEvent
    {
        DateTime OccurredOn {get;}
    }
}