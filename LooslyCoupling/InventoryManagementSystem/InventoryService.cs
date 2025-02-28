using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LooslyCoupling.InventoryManagementSystem
{
    public class InventoryService
    {
        private readonly IInventoryRepository _inventoryRepository;

        public InventoryService(IInventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
        }

        public IEnumerable<InventoryItem> GetLowStockItems()
        {
            return _inventoryRepository.GetAll().Where(x => x.Quantity < 10);
        }
    }
}