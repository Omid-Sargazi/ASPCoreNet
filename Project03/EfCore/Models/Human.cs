using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfCore.Models
{
    public class Human
    {
        public int ID {get;set;}
        public int Age {get;set;}
        public string NameFamily {get;set;}
        //public int  Sex { get; set; }//-1,0,1

        public Sex SetSex {get; set;}

        public enum Sex
        {
            male=0, famale=1,n=-1
        }
        
        
    }
}