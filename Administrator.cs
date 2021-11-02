using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Booking_system
{
    // Administrator can not make an reservation. This type of account is for employees who need to retrieved data from database.

    public class Administrator:ILogable
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

        [Required]
        private string Password { get; set; }

        public class AdministratorConfiguration : EntityTypeConfiguration<Administrator>
        {
            public AdministratorConfiguration()
            {
                Property(p => p.Password);
            }
        }


        public bool Login()
        {
            DatabaseManager dbManager = new DatabaseManager();
            var user = dbManager.Find(this);
            if (user.GetPassword() == GetPassword())
            {
                return true;
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
    }
}
