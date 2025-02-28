using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LooslyCoupling.WithoutDI;

namespace LooslyCoupling.WithDI
{
    public interface IOrderRepository
    {
       public IEnumerable<Order> GetAll(); 
    }
}