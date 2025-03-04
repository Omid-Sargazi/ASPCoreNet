using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryManagementSystem.Domain.Exceptions;

namespace InventoryManagementSystem.Domain.Entities
{
    public class Category:BaseEntity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public bool IsActive { get; private set; }

        public ICollection<Product> Products {get; private set;} = new List<Product>();

        private Category(){} 

        public void SetName(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Category name is required.");
            if(name.Length > 100)
                throw new ArgumentException("Category name cannot be more than 100 characters.");
            Name = name.Trim();
        }

        public void SetDescription(string description)
        {
            if(description?.Length > 500)
            {
                throw new ArgumentException("Description cannot be more than 500 characters.");
            }

            Description = description?.Trim();
        }

        public void Activate()
        {
            IsActive = true;
        }

        public void Deactivate()
        {
            IsActive = false;
        }
    }
}