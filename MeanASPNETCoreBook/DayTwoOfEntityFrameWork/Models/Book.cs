using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayTwoOfEntityFrameWork.Models
{
    public class Book
    {
        public int BookId {get; set;}
        public string Title { get; set; }
        public int AuthorId { get; set; } 
        public Author Author {get;set;}
        public List<Review> Reviews {get; set;} = new List<Review>();
        
    }
}