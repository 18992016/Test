using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebHotel.Models
{
    public class Booking
    {
        [Key]
        public int bookingId { get; set; }

        public int roomId { get; set; }

        public string customerEmail { get; set; }

        [DataType(DataType.Date)]
        public DateTime checkIn { get; set; }

        [DataType(DataType.Date)]
        public DateTime checkOut { get; set; }

        [DataType(DataType.Currency)]
        public float cost { get; set; }

        public Room theRoom { get; set; }

        public Customer theCustomer { get; set; }
    }
}
    
