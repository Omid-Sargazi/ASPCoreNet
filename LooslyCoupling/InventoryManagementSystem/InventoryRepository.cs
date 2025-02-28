using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LooslyCoupling.InventoryManagementSystem
{
    public class InventoryRepository : IInventoryRepository
    {
        public IEnumerable<InventoryItem> GetAll()
        {
            return new List<InventoryItem> 
            {
                new InventoryItem { Id = 1, Name = "Laptop", Quantity = 5 },
                new InventoryItem { Id = 2, Name = "Mouse", Quantity = 15 }
            };
        }
    }
}