using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LINQExample.Models
{
    public class AuthorContact
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int AuthorId { get; set; } // Foreign Key
        public Author Author { get; set; } // Navigation Property
    }
}