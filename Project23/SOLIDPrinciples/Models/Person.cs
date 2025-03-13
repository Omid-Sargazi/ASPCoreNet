using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLIDPrinciples.Models
{
    public class Person
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}

        public string getFullName()
        {
            return $"{LastName } {FirstName}";
        }
    }

}