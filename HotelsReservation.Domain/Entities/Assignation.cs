using System;
namespace HotelsReservation.Domain.Entities
{
	public class Assignation
	{
		public int RoomId { get; set; }
		public Room Room { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
	}
}

