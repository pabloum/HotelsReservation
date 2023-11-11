using System;
using HotelsReservation.Domain.Entities;
using HotelsReservation.Services.Contracts;
using HotelsReservation.Services.Implementations;
using Microsoft.AspNetCore.Mvc;

namespace HotelsReservation.Api.Controllers
{
	public class RoomController : BaseController
    {
        private IRoomService _roomService;

        public RoomController(IRoomService roomService)
		{
            _roomService = roomService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllRooms()
        {
            return Ok(await _roomService.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> CreateRoom(Room room)
        {
            return Ok(await _roomService.CreateRoom(room));
        }

        [HttpGet]
        public async Task<IActionResult> ReadRoom(int id)
        {
            return Ok(await _roomService.ReadRoom(id));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateRoom(Room hotel)
        {
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteRoom(int id)
        {
            await _roomService.DeleteRoom(id);
            return Ok();
        }
    }
}

