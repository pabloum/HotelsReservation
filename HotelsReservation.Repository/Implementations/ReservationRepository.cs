using HotelsReservation.Domain.Context;
using HotelsReservation.Domain.Entities;
using HotelsReservation.Repository.Contracts;

namespace HotelsReservation.Repository.Implementations
{
    public class ReservationRepository : BaseRepository<int, Assignation>, IReservationRepository
    {
        public ReservationRepository(HotelsReservationsDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Assignation>> GetAssignationsForRoomAsync(int roomId, bool futureReservations = true)
        {
            return await base.GetAllAsync(r => r.RoomId == roomId);
        }

        public async Task<IEnumerable<Assignation>> GetAssignationsForHotelAsync(int hotelId, bool futureReservations = true)
        {
            return await base.GetAllAsync(r => r.RoomId == hotelId);
        }
    }
}