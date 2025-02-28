using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LooslyCoupling.BloggingSystem
{
    public class BlogRepository : IBlogRepository
    {
        public IEnumerable<BlogPost> GetAll()
        {
            return new List<BlogPost>
            {
                new BlogPost { Id = 1, Title = "First Blog Post", PublishedDate = DateTime.Now },
                new BlogPost { Id = 2, Title = "Second Blog Post", PublishedDate = DateTime.Now },
                new BlogPost { Id = 3, Title = "Third Blog Post", PublishedDate = DateTime.Now }
            };
        }
    }
}