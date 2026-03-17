using LabHotelManagment.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace LabHotelManagment.Context
{
    public class HotelContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["hotel"].ConnectionString);
        public virtual DbSet<Guest> Guests { set; get; }
        public virtual DbSet<Login> Logins { set; get; }
        public virtual DbSet<Room> Rooms { set; get; }
        public virtual DbSet<Reservation> Reservations { set; get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>().Property(r => r.RoomNumber).ValueGeneratedNever();  //key is not identity
        }

    }
}
