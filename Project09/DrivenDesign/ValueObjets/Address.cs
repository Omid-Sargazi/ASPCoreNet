using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrivenDesign.ValueObjets
{
    public class Address
    {
    public string Street { get; private set; }
    public string City { get; private set; }
    public string PostalCode { get; private set; }

    public Address(string street, string city, string postalCode)
    {
        Street = street;
        City = city;
        PostalCode = postalCode;
    }
    }
}