using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebHotel.Models
{
    public class Customer
    {
        [Key, Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string email { get; set; }

        public String sName { get; set; }

        public String fName { get; set; }

        public String postCode { get; set; }

        public ICollection<Booking> theBookings { get; set; }
    }
}
