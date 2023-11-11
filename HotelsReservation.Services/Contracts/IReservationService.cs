using System;
using HotelsReservation.Domain.Entities;

namespace HotelsReservation.Services.Contracts
{
	public interface IReservationService : IService
	{
		Task CreateReservation(Assignation reservation);
		Task CancelReservation(int id);
		Task<IEnumerable<Assignation>> GetReservationsForRoom(int roomId);
		Task<IEnumerable<Assignation>> GetReservationsForHotel(int hotelId);
    }
}

