using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Season4.Models
{
    public class Review
    {
        public int ReviewId {get; set;}
        public string Reviewer {get; set;}
        public int Rating {get; set;}

        public int BookId {get; set;}
        public Book Book {get; set;}
    }
}