using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicCommandResponse.Commnands
{
    public class ProcessOrderCommand:Command
    {
        public string ProductName {get; set;}
        public int Quantity {get; set;}

        public ProcessOrderCommand(string productName, int quantity)
        {
            ProductName = productName;
            Quantity = quantity;
        }
    }
}