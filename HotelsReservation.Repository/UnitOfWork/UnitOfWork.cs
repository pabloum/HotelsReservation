using System;
using HotelsReservation.Domain.Context;
using HotelsReservation.Repository.Contracts;
using HotelsReservation.Repository.Implementations;
using Microsoft.EntityFrameworkCore;

namespace HotelsReservation.Repository.UnitOfWork
{

    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly HotelsReservationsDbContext _context;
        private bool _disposed = false;
        private IHotelRepository _hotelRepository;
        private IRoomRepository _roomRepository;
        private IReservationRepository _reservationRepository;

        public UnitOfWork(HotelsReservationsDbContext context)
        {
            _context = context;
        }

        public IHotelRepository HotelRepository
        {
            get
            {
                _hotelRepository ??= new HotelRepository(_context);
                return _hotelRepository;
            }
        }

        public IRoomRepository RoomRepository
        {
            get
            {
                _roomRepository ??= new RoomRepository(_context);
                return _roomRepository;
            }
        }

        public IReservationRepository ReservationRepository
        {
            get
            {
                _reservationRepository ??= new ReservationRepository(_context);
                return _reservationRepository;
            }
        }

        public async Task SaveAsync()
        {
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                ex.Entries.Single().Reload();
            }
        }

        #region IDisposable
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.DisposeAsync();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    }
}