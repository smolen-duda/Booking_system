using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Booking_system
{
    // Rooms available in the hotel.

    public class Room
    {
        [Key]
        public int RoomID { get; set; }
        [Required]
        public int Number { get; set; }

        [Required]
        public decimal Fee { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
    }
}
