using System;
using System.Data.Entity;

namespace Booking_system
{
    public class Context : DbContext
    {
        public Context() : base("Hotel_Database")
        {

        }

        public DbSet<User> Users;
        public DbSet<Administrator> Administrators;
        public DbSet<Reservation> Reservations;
        public DbSet<Room> Rooms;

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Configurations.Add(new Administrator.AdministratorConfiguration());
            modelBuilder
                .Configurations.Add(new User.UserConfiguration());
        }
    }

}
