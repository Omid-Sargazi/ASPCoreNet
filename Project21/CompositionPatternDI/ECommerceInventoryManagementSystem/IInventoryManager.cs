using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompositionPatternDI.ECommerceInventoryManagementSystem
{
    public interface IInventoryManager
    {
        void AddProduct(IProduct product);
        void UpdateProductQuantity(int productId, int quantity);
        bool CheckAvailability(int productId);
        void ListProducts();
    }
}