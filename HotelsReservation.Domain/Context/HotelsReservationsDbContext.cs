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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>(entity =>
            {
                entity.HasKey(r => r.Id);
                entity.ToTable("Rooms");
            });

            modelBuilder.Entity<Hotel>(entity =>
            {
                entity.HasKey(r => r.Id);
                entity.ToTable("Hotels");
            });
        }
    }
}

