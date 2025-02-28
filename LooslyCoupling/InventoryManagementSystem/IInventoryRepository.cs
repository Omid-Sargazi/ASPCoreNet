using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LooslyCoupling.InventoryManagementSystem
{
    public interface IInventoryRepository
    {
        public IEnumerable<InventoryItem> GetAll();
    }
}