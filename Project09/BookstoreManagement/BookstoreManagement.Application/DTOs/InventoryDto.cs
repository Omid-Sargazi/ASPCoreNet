using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreManagement.Application.DTOs
{
    public class InventoryDto
    {
        public int Id {get; set;}
        public string BookTitle {get; set;}
        public int Quantity {get; set;}
    }
}