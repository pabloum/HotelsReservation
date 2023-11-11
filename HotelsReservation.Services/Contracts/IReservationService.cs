using System;
namespace HotelsReservation.Services.Contracts
{
	public interface IReservationService : IService
	{
		Task CreateReservatiob();
		Task CancelReservation(int id);
		Task GetReservationsForRoom(int roomId);
		Task GetReservationsForHotel(int hotelId);
    }
}

