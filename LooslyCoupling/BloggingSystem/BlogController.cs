using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LooslyCoupling.BloggingSystem
{
    public class BlogController:Controller
    {
        private readonly BlogService _blogService;

        public BlogController(BlogService blogService)
        {
            _blogService = blogService;
        }

        public IActionResult Index()
        {
            var resentBlog = _blogService.GetRecentPosts();
            return View(resentBlog);
        }
    }
}