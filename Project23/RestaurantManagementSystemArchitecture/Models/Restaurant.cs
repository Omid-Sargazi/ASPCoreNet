using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManagementSystemArchitecture.Models
{
    public class Restaurant
    {
        public Guid Id {get; private set;}
        public string Name {get; private set;}
        public string Address { get; private set; }
        public string PhoneNumber { get; private set; }
        public DateTime OpeningHours { get; private set; }
        public DateTime ClosingHours { get; private set; }
        public bool IsActive { get; private set; }
        public ICollection<Menu> Menus {get; private set;}
        public ICollection<Table> Tables {get; private set;}
        public ICollection<Reservation> Reservations {get; private set;}
    }
}