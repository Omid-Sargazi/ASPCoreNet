using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.ValueObjects
{
    public class Address
    {
        public string Street { get; }
        public string City { get; }
        public string ZipCode { get; }

        public Address(string street, string city, string zipcode)
        {
            if(string.IsNullOrWhiteSpace(street)||string.IsNullOrWhiteSpace(city))
                throw new ArgumentException("Address fields cannot be empty.");
            Street = street;
            City = city;
            ZipCode = zipcode;
        }

        public override bool Equals(object? obj)
        {
            if(obj is not Address other) return false;
            return Street == other.Street && City == other.City && ZipCode == other.ZipCode;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Street, City, ZipCode);
        }
    }
}