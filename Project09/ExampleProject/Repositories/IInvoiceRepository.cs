using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleProject.Entities;

namespace ExampleProject.Repositories
{
    public interface IInvoiceRepository
    {
        Invoice GetById(Guid id);
        void Save(Invoice invoice);
    }
}