using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfCore.Models
{
    public class Education
    {
        public int ID {get;set;}
        public string Title {get;set;}
        public int Code {set;get;}
        public string Description {get;set;}

        public int Point {get;set;}
    }
}