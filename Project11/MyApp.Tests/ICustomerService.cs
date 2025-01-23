using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Tests
{
    public interface ICustomerService
    {
        Customer getCustomerById(int id);
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}