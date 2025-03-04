using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Domain.Entities
{
    public abstract class BaseEntity
    {
        public int Id {get; set;}

        // Audit Fields
        public DateTime CreatedAt { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }

        // Soft Delete
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }

        public override bool Equals(object? obj)
        {
            if(obj is not BaseEntity other)
            {
                return false;
            }

            if(ReferenceEquals(this, other))
            {
                return true;
            }

            if(Id == 0 || other.Id == 0)
            {
                return false;
            }

            return Id == other.Id;
        }

       public static bool operator ==(BaseEntity a, BaseEntity b)
        {
        if (ReferenceEquals(a, b)) return true;
        if (ReferenceEquals(a, null) || ReferenceEquals(b, null)) return false;

        return a.Equals(b);
         }
     public static bool operator !=(BaseEntity a, BaseEntity b)
        {
        return !(a == b);
        }

        public override int GetHashCode()
        {
            return (Id !=0) ?Id.GetHashCode() : base.GetHashCode();
        }

        public virtual void Delete(string deletedBy)
        {
            IsDeleted = true;
            DeletedAt = DateTime.UtcNow;
            DeletedBy = deletedBy;
        }

        public virtual void Restore()
        {
            IsDeleted = false;
            DeletedAt = null;
            DeletedBy = null;
        }
    }
}