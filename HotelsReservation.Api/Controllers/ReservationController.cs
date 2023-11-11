using System;
using HotelsReservation.Domain.Entities;
using HotelsReservation.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace HotelsReservation.Api.Controllers
{
	public class ReservationController : BaseController
	{
		private IReservationService _reservationService;

		public ReservationController(IReservationService reservationService)
		{
			_reservationService = reservationService;
        }

		[HttpPost]
		public async Task<IActionResult> CreateReservation([FromBody]Assignation reservation)
		{
			await _reservationService.CreateReservation(reservation);
			return Ok();
		}

		[HttpGet("GetAllForHotel")]
		public async Task<IActionResult> GetAllReservationsForHotel(int hotelId)
		{
			return Ok(await _reservationService.GetReservationsForHotel(hotelId));
		}

        [HttpGet("GetAllForRoom")]
        public async Task<IActionResult> GetAllReservationsForRoom(int roomId)
        {
            return Ok(await _reservationService.GetReservationsForRoom(roomId));
        }

		[HttpDelete]
		public async Task<IActionResult> CancelReservation(int id)
		{
			await _reservationService.CancelReservation(id);
			return Ok();
		}
    }
}

