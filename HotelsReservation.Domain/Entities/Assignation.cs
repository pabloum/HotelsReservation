using System;
namespace HotelsReservation.Domain.Entities
{
	public class Assignation : BaseEntity<int>
	{
		public int RoomId { get; set; }
		public Room Room { get; set; }

		public int HotelId { get; set; }
		public Hotel Hotel { get; set; }

		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
	}
}

