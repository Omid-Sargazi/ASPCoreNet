using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IBookInventory
    {
        
        bool CheckAvailability(int bookId, int quantity);
        void ReduceStock(int bookId, int qquantity);
    }
}