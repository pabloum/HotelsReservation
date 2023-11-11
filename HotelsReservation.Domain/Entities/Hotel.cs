using System;
namespace HotelsReservation.Domain.Entities
{
	public class Hotel : BaseEntity<int>
	{
		public string Name { get; set; }
		public ICollection<Room> Rooms { get; set; }
	}
}

