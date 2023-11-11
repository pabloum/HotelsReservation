using System;
using HotelsReservation.Domain.Entities;
using HotelsReservation.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace HotelsReservation.Api.Controllers
{
	public class HotelController : BaseController
    {
		private IHotelService _hotelService;

		public HotelController(IHotelService hotelService)
		{
			_hotelService = hotelService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllHotels()
        {
            return Ok(await _hotelService.GetAll());
        }

		[HttpPost]
		public async Task<IActionResult> CreateHotel(Hotel hotel)
		{
			return Ok(await _hotelService.CreateHotel(hotel));
		}

        [HttpGet]
        public async Task<IActionResult> ReadHotel(int id)
        {
            return Ok(await _hotelService.ReadHotel(id));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateHotel(Hotel hotel)
        {
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteHotel(int id)
        {
            await _hotelService.DeleteHotel(id);
            return Ok();
        }
    }
}

