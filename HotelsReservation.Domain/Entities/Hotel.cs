using System;

namespace HotelsReservation.Domain.Entities
{
	public class Hotel : BaseEntity<int>
	{
		public string Name { get; set; }
		public string Country { get; set; }
		public string City { get; set; }

        public ICollection<Room> Rooms { get; set; }

		public bool IsActive { get; set; }
	}
}

