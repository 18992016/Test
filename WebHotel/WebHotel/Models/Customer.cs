using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebHotel.Models
{
    public class Customer
    {
        [Key, Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"[A-Za-z-']")]
        [Range(2, 20)]
        public string Surname { get; set; }

        [Required]
        [RegularExpression(@"[A-Za-z-']")]
        [Range(2, 20)]
        public string GivenName { get; set; }

        [Required]
        [RegularExpression(@"{4}")]
        public string Postcode { get; set; }
        public ICollection<Booking> TheBookings { get; set; }
    }
}
