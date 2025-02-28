using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LooslyCoupling.BloggingSystem
{
    public class BlogService
    {
        private readonly IBlogRepository _blogRepository;

        public BlogService(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public IEnumerable<BlogPost> GetRecentPosts()
        {
            return _blogRepository.GetAll().OrderByDescending(p => p.PublishedDate).Take(5);
        }
    }
}