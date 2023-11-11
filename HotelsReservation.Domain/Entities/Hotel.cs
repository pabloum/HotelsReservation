using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelsReservation.Domain.Entities
{
	public class Hotel : BaseEntity<int>
	{
		public string Name { get; set; }
		public string Country { get; set; }
		public string City { get; set; }

		//[NotMapped]
        public ICollection<Room> Rooms { get; set; }
	}
}

