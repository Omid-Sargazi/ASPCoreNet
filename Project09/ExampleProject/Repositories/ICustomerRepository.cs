using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using ExampleProject.Entities;

namespace ExampleProject.Repositories
{
    public interface ICustomerRepository
    {
        Customer GetById(Guid id);
        void Save(Customer customer);
        void Delete(Guid id);
    }
}