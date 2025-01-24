using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomainEventMediatR.Aggregates
{
    public class Address
    {
        public string Street { get; }
        public string City { get; }
        public string ZipCode { get; }

         public Address(string street, string city, string zipCode)
        {
            if (string.IsNullOrWhiteSpace(street) || string.IsNullOrWhiteSpace(city) || string.IsNullOrWhiteSpace(zipCode))
                throw new ArgumentException("Invalid address fields.");

            Street = street;
            City = city;
            ZipCode = zipCode;
        }

        public override bool Equals(object? obj)
        {
            if (obj is not Address other) return false;
            return Street == other.Street && City == other.City && ZipCode == other.ZipCode;
        }

        public override int GetHashCode() => HashCode.Combine(Street, City, ZipCode);
    }
}
