using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Booking_system
{
    // Rooms available in the hotel.

    public class Room
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoomID { get; set; }
        [Required]
        [Index("IX_UniqueConstraint", 1, IsUnique = true)]
        public int Number { get; set; }

        [Required]
        public int NumberOfBeds { get; set; }

        [Required]
        public decimal Fee { get; set; }


        public ICollection<Reservation> Reservations { get; set; }
    }
}
