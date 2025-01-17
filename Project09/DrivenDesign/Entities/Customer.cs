using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrivenDesign.Entities
{
    public class Customer
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}