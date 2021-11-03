using System;
using System.Data.Entity;

namespace Booking_system
{
    public class Context : DbContext
    {
        public Context() : base("Hotel_Database")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Room> Rooms { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Configurations.Add(new Administrator.AdministratorConfiguration());
            modelBuilder
                .Configurations.Add(new User.UserConfiguration());
        }
    }

}
