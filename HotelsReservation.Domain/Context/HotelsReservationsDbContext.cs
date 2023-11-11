using System;
using HotelsReservation.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelsReservation.Domain.Context
{
	public class HotelsReservationsDbContext : DbContext, IDisposable
    {
		public HotelsReservationsDbContext(DbContextOptions<HotelsReservationsDbContext> options) : base(options)
        {
		}

		public virtual DbSet<Hotel> Hotels { get; set; }

		public virtual DbSet<Room> Rooms { get; set; }

		public virtual DbSet<Room> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>(entity =>
            {
                entity.HasKey(r => r.Id);
                entity.HasOne(r => r.Hotel).WithMany(h => h.Rooms).HasForeignKey(r => r.HotelId);
                entity.ToTable("Rooms");
            });

            modelBuilder.Entity<Hotel>(entity =>
            {
                entity.HasKey(r => r.Id);
                entity.ToTable("Hotels");
            });

            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.HasKey(r => r.Id);
                entity.ToTable("Reservations");
            });
        }
    }
}

