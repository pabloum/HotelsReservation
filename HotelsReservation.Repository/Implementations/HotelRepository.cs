using System;
using HotelsReservation.Domain.Context;
using HotelsReservation.Domain.Entities;
using HotelsReservation.Repository.Contracts;

namespace HotelsReservation.Repository.Implementations
{
	public class HotelRepository : BaseRepository<int, Hotel>, IHotelRepository
	{
		public HotelRepository(HotelsReservationsDbContext context) : base(context)
		{
		}
	}
}

