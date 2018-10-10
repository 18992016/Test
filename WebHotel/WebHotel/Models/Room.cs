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

        [RegularExpression("^[G,g,1,2,3]{1}$")]
        public String level { get; set; }

        [RegularExpression("^[1-3]{1}$")]
        public int bedCount { get; set; }

        [RegularExpression("^$5[0-9]$")]
        public float price { get; set; }

        //test comment
        public ICollection<Booking> theBookings { get; set; }
    }
}
