using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependanyInjection.Repositories
{
    public interface IProductRepository
    {
        List<string> GetProducts();
    }
}