using System;
using HotelsReservation.Repository.Contracts;

namespace HotelsReservation.Repository.UnitOfWork
{
	public interface IUnitOfWork
	{
        IHotelRepository HotelRepository { get; }
        IRoomRepository RoomRepository { get; }
        IReservationRepository ReservationRepository { get; }

        Task SaveAsync();
    }
}

