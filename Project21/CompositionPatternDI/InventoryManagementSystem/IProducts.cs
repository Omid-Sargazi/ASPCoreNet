using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace CompositionPatternDI.InventoryManagementSystem
{
    public interface IProducts
    {
        string ProductId {get;}
        string Name {get;}
        decimal Price {get;}
        int Quantity {get;}
        ProtocolType Type {get;}
        void UpdateQuantity(int quantity);
        bool IsAvailable();
        
    }

    public enum ProductType
    {
        Phisical,
        Digital, 
        Subscription
    }
}