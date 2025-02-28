using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LooslyCoupling.BloggingSystem
{
    public interface IBlogRepository
    {
        public IEnumerable<BlogPost> GetAll();
    }
}