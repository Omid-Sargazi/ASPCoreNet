using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreManagement.Application.DTOs
{
    public class CategoryDto
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public List<string> BookTitles {get; set;} = new List<string>();
    }
}