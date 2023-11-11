using System;
using HotelsReservation.Domain.Entities;

namespace HotelsReservation.Services.Contracts
{
	public interface IHotelService : IService
    {
		Task<Hotel> CreateHotel(Hotel hotel);
	}
}

