﻿using System;
namespace HotelsReservation.Domain.Entities
{
	public class Room
	{
		public int Id { get; set; }
		public string Number { get; set; }
		public int HotelId { get; set; }
		public Hotel Hotel { get; set; }
	}
}

