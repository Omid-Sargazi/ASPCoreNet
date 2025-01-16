using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreManagementSystem.Domain.ValueObjects
{
    public class Money
    {
        public decimal Amount {get; private set;}
        public string Currency {get; private set;}

        public Money(decimal amount, string currency)
        {
            if(amount <0)
                throw new Exception("Price can not be negative");
            Amount = amount;
            Currency = currency ?? throw new ArgumentNullException(nameof(currency));
        }


        public override bool Equals(object obj)=>
        obj is Money money && 
        money.Amount == Amount &&
        money.Currency == Currency;

        public override int GetHashCode()=>
            HashCode.Combine(Amount, Currency);


    }

}