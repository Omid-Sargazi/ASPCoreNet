using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleProject.Entities;

namespace ExampleProject.Repositories
{
    public interface IOrderRepository
    {
         Order GetById(Guid id);
        void Save(Order order);
        void Delete(Guid id);
    }
}