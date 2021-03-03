using System;
using System.Collections.Generic;

namespace DotNetCoreProject_Sayed.Models
{
    
    
    public partial class Customer
    {
     
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int PhoneNo { get; set; }
    
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
