using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderProcessingSystem.Services
{
    public class ShippingLabel
    {
        public string TrackingNumber { get; set; }
        public string CarrierName { get; set; }
        public string LabelUrl { get; set; }
    }
}