using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoookAPIs2.DTOs
{
    public class AuthorDto
    {
        public int Id {get;set;}
        public string Name {get;set;}
        public List<string> BookTitles {get;set;}
    }
}