using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Tests.Payment
{
    public interface IInventoryService
    {
        bool IsItemAvailable(int itemId, int quantity);
        void ReserveItem(int itemId, int quantity);
    }
}