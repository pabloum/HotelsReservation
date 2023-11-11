using System;
using HotelsReservation.Services.Contracts;

namespace HotelsReservation.Services.Implementations
{
	public class ReservationService : IReservationService
    {
		public ReservationService()
		{
		}

        public Task CancelReservation(int id)
        {
            throw new NotImplementedException();
        }

        public Task CreateReservatiob()
        {
            throw new NotImplementedException();
        }

        public Task GetReservationsForHotel(int hotelId)
        {
            throw new NotImplementedException();
        }

        public Task GetReservationsForRoom(int roomId)
        {
            throw new NotImplementedException();
        }
    }
}

