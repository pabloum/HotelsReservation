using System;
using HotelsReservation.Domain.Context;
using HotelsReservation.Domain.Entities;
using HotelsReservation.Repository.Contracts;

namespace HotelsReservation.Repository.Implementations
{
	public class RoomRepository : BaseRepository<int, Room>, IRoomRepository
	{
		public RoomRepository(HotelsReservationsDbContext context) : base(context)
		{
		}
	}
}

