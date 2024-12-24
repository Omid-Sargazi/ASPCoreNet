using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoookAPIs2.DTOs
{
    public class BookDto
    {
        public int Id {get;set;}
        public string Title {get;set;}
        public string AuthorName { get; set; }
        public string GenreName { get; set; }
    }
}