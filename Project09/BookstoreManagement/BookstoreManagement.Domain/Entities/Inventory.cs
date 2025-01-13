using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreManagement.Domain.Entities
{
    public class Inventory
    {
        public int Id { get; private set; }
        public int BookId { get; private set; }
        public Book Book { get; private set; }
        public int Quantity { get; private set; }



        public Inventory(int bookId, int quantity)
        {
            if (quantity < 0)
                throw new ArgumentException("Quantity cannot be negative.");

            BookId = bookId;
            Quantity = quantity;
        }

         public void AddStock(int amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Stock amount must be positive.");

            Quantity += amount;
        }


         public void RemoveStock(int amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Stock amount must be positive.");
            if (amount > Quantity)
                throw new InvalidOperationException("Cannot remove more stock than available.");

            Quantity -= amount;
        }
    }
}