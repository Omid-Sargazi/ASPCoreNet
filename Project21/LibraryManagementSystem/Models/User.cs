using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class User
    {
         public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime RegistrationDate { get; set; }
        public UserAddress Address { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Review> Reviews {get; set;}
        public ICollection<BorrowTransaction> BorrowTransactions {get; set;}
    }
}