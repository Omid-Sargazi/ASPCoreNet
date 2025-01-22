using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.ValueObjects
{
    public class Money
    {
        public decimal Amount {get;}
        public string Currency {get;}

        public Money(decimal amount, string currency)
        {
            if(amount < 0 )
                throw new ArgumentException("Amount cannot be negative.");
            
            if(string.IsNullOrWhiteSpace(currency))
                throw new ArgumentException("Currency cannot be empty.");
            
            Amount = amount;
            Currency = currency.ToUpper();
        }

        public Money Add(Money other)
        {
            if(Currency != other.Currency)
                throw new InvalidOperationException("Currencies must match to perform operations.");
            
            return new Money(Amount + other.Amount, Currency);
        }

        public override bool Equals(object? obj)
        {
            if(obj is not Money other) return false;
            return Amount == other.Amount && Currency == other.Currency;
        }


        public override int GetHashCode() => HashCode.Combine(Amount, Currency);
    }
}