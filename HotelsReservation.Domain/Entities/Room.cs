using System;
namespace HotelsReservation.Domain.Entities
{
	public class Room : BaseEntity<int>
    {
		public string Number { get; set; }
		public int HotelId { get; set; }
		public Hotel Hotel { get; set; }
	}
}

