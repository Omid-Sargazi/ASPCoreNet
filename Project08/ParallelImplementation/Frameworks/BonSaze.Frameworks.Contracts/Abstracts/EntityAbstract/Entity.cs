using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BonSaze.Frameworks.Contracts.Abstracts.EntityAbstract
{
    public abstract class Entity<T>
    {
         public T Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; }
    }
}