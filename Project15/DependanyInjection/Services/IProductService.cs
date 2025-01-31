using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependanyInjection.Services
{
    public interface IProductService
    {
        List<string> GetAllProducts();
    }
}