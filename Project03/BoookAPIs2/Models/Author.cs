using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoookAPIs2.Models
{
    public class Author
    {
        public int Id {get;set;}
        public string Name {get;set;}
        public ICollection<Book> Books {get;set;}
    }
}