using System;
namespace HotelsReservation.Domain.Entities
{
	public class Room : BaseEntity<int>
    {
		public string Number { get; set; }
		public int HotelId { get; set; }
		public Hotel Hotel { get; set; }

		public decimal? BaseCost { get; set; }
		public decimal? Tax { get; set; }

		public string? RoomType { get; set; }
		public bool IsActive { get; set; }
    }
}

