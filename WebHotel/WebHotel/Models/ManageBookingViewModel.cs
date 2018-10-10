using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebHotel.Models
{
    public class ManageBookingViewModel
    {   
        [Range(1,16), Display(Name ="Room ID")]
        public int RoomID { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"[A-Za-z - ']{2,20}$")]
        [Display(Name ="Custoemr Surname")]
        public string Surname { get; set; }

        [Required]
        [RegularExpression(@"[A-Za-z - ']{2,20}$")]
        [Display(Name = "Customer Given Name")]
        public string GivenName { get; set; }

        [DataType(DataType.Date), Display(Name ="Checking In Date")]
        public DateTime CheckIn { get; set; }

        [DataType(DataType.Date), Display(Name = "Checking Out Date")]
        public DateTime CheckOut { get; set; }

        [DataType(DataType.Currency)]
        public decimal Cost { get; set; }

        [RegularExpression(@"[G123]{1}"), Display(Name ="Room Level")]
        public string Level { get; set; }

        [RegularExpression(@"[123]{1}"), Display(Name ="Bed Count")]
        public int BedCount { get; set; }
    }
}
