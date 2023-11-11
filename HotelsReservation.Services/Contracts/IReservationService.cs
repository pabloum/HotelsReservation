using System;
using HotelsReservation.Domain.Entities;

namespace HotelsReservation.Services.Contracts
{
	public interface IReservationService : IService
	{
		Task CreateReservation(Reservation reservation);
		Task CancelReservation(int id);
		Task<IEnumerable<Reservation>> GetReservationsForRoom(int roomId);
		Task<IEnumerable<Reservation>> GetReservationsForHotel(int hotelId);
    }
}

