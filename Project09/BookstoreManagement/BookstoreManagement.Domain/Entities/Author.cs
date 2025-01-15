using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreManagement.Domain.Entities
{
    public class Author
    {
        public int Id {get; private set;}
        public string Name {get; private set;}
        public List<Book> Books {get; private set;} = new List<Book>();
        

        public Author(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("Author name cannot be empty.");
            
            Name = name;
        }
    }
}