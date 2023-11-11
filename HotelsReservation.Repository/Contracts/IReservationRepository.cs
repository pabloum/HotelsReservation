using System;
using HotelsReservation.Domain.Entities;

namespace HotelsReservation.Repository.Contracts
{
	public interface IReservationRepository : IBaseRepository<int, Assignation>
    {
        Task<IEnumerable<Assignation>> GetAssignationsForRoomAsync(int roomId, bool futureReservations = true);
        Task<IEnumerable<Assignation>> GetAssignationsForHotelAsync(int hotelId, bool futureReservations = true);
    }
}

