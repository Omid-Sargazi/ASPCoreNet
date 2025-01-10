using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BonSaze.Domains.Domain
{
    public abstract class Entity<T>
    {
      public T Id { get; protected set; }
    public bool IsDeleted { get; protected set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedAt { get; set; }
    public Guid? ModifiedBy { get; set; }
    public DateTime? ModifiedAt { get; set; }

    public void SetDelete()
    {
        IsDeleted = true;
    }
    }
}