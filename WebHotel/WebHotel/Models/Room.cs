using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebHotel.Models
{
    public class Room
    {
        [Key, Required]
        public int roomId { get; set; }

        public String level { get; set; }

        public int bedCount { get; set; }

        public float price { get; set; }

        //test comment
        public ICollection<Booking> theBookings { get; set; }
    }
}
