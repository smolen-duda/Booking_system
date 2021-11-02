using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Booking_system
{
    public class Reservation
    {
        [Key]
        public int ReservationID {get; set;}

        [Column("From")]
        [Required]
        public DateTime FromDate { get; set; }
        [Column("To")]
        [Required]
        public DateTime ToDate { get; set; }
        [Column("Ordereed")]
        [Required]
        public DateTime DateOfReservationMaking { get; set; } = DateTime.UtcNow;

        // Summary of the fees for all booked rooms.
        [Required]
        public decimal Fee { get; set; }


        // Possible values are: Not paid, Paid, Canceled.
        [Required]
        public string Status { get; set; } = "Not paid";


        [Required]
        public User User { get; set; }

        [Required]
        public ICollection<Room> Rooms { get; set; }
    }
}
