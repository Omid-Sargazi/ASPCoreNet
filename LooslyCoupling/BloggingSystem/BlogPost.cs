using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LooslyCoupling.BloggingSystem
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime PublishedDate { get; set; }
    }
}