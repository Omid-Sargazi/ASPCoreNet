using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ShallowCopy.ShalowCopy02
{
    public class ShallowPerson
    {
        public string Name {get; set;}
        public ShallowAddress ShallowAddress {get; set;}

        
        public ShallowPerson ShallowCopy()
        {
            return (ShallowPerson)this.MemberwiseClone();
        }
    }
}