using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Booking_system
{
    // User are hotel guests, they can make reservations.
    public class User : ILogable
    {
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

        [Required]
        private string Password { get; set; }

        public ICollection<Reservation> Reservations { get; set; }


        public class UserConfiguration : EntityTypeConfiguration<User>
        {
            public UserConfiguration()
            {
                Property(p => p.Password);
            }
        }

        public bool Login(DatabaseManager dbManager)
        {
            var user = dbManager.Find(this);

            if (user != null)
            {
                if (user.GetPassword() == GetPassword())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public string GetID()
        {
            return ID;
        }
        public string GetPassword()
        {
            return Password;
        }
        public void SetPassword(string pass)
        {
            Password = pass;
        }
    }
}
