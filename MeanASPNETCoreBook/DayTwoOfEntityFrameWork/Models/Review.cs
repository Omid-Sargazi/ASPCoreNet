using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayTwoOfEntityFrameWork.Models
{
    public class Review
    {
         public int ReviewId { get; set; }
        public string Comment { get; set; }
        public int BookId { get; set; } // Foreign key to Book
        public Book Book { get; set; } // Navigation property to Book
    }
}