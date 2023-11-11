using HotelsReservation.Domain.Entities;
using HotelsReservation.Repository.UnitOfWork;
using HotelsReservation.Services.Contracts;

namespace HotelsReservation.Services.Implementations
{
    public class ReservationService : IReservationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ReservationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task CancelReservation(int id)
        {
            await _unitOfWork.ReservationRepository.Delete(id);
        }

        public Task CreateReservation(Reservation reservation)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Reservation>> GetReservationsForHotel(int hotelId)
        {
            return await _unitOfWork.ReservationRepository.GetAssignationsForHotelAsync(hotelId);
        }

        public async Task<IEnumerable<Reservation>> GetReservationsForRoom(int roomId)
        {
            return await _unitOfWork.ReservationRepository.GetAssignationsForRoomAsync(roomId);
        }
    }
}

