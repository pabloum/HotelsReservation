using System;
using HotelsReservation.Domain.Entities;

namespace HotelsReservation.Repository.Contracts
{
	public interface IReservationRepository : IBaseRepository<int, Reservation>
    {
        Task<IEnumerable<Reservation>> GetAssignationsForRoomAsync(int roomId, bool futureReservations = true);
        Task<IEnumerable<Reservation>> GetAssignationsForHotelAsync(int hotelId, bool futureReservations = true);
    }
}

