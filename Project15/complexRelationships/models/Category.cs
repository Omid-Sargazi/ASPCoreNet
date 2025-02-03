using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace complexRelationships.models
{
    public class Category
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public List<BookCategory> BookCategories {get; set;} = new List<BookCategory>();
    }
}