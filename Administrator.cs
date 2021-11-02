using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Booking_system
{
    // Administrator can not make an reservation. This type of account is for employees who need to retrieved data from database.

    public class Administrator
    {
        [Key]
        public int AdministratorID {get; set;}

        [StringLength(11)]
        [Required]
        [Index("IX_UniqueConstraint", 1, IsUnique = true)]
        public string ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
    }
}
