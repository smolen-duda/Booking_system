using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Booking_system
{
    // User are hotel guests, they can make reservations.
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [StringLength(11)]
        [Required]
        [Index("IX_UniqueConstraint", 1, IsUnique = true)]
        public string ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }

        [Column("Phone Number")]
        public string PhoneNumber { get; set; }
        [EmailAddress, Required]
        public string Email { get; set; }

        public ICollection<Reservation> Reservations { get; set; }


    }
}
