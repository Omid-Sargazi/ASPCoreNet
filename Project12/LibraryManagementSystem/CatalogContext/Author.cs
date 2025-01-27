using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogContext
{
    public class Author
    {
        public string FirstName {get; private set;}
        public string Lastname {get; private set;}

        public Author(string firstName, string lastName)
        {
            FirstName = firstName;
            Lastname = lastName;    
        }
    }
}