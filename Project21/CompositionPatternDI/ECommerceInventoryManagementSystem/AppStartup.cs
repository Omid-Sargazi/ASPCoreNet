using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompositionPatternDI.ECommerceInventoryManagementSystem
{
    public static class AppStartup
    {
        public static IInventoryManager ConfigureInventorySystem()
        {
            var inventoryManager = new InventoryManager();
            
            inventoryManager.AddProduct(new PhysicalProduct(1,1200m, "laptop", 10));
            inventoryManager.AddProduct(new DigitalProduct(2,120m,"filem",20,"url"));
            inventoryManager.AddProduct(new SubscriptionProduct(3,"streeaming service",100m,2,150));

            return inventoryManager;
        }
    }
}