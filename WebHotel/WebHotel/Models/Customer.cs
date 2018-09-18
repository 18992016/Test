using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebHotel.Models
{
    public class Customer
    {
        public string Email { get; set; }

        public string Surname { get; set; }

        public string GivenName { get; set; }

        public string Postcode { get; set; }

        public ICollection<Booking> TheBookings { get; set; }
    }
}
