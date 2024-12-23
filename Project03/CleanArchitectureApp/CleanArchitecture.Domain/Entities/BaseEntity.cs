using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id {get; protected set;} = Guid.NewGuid();
    }
}