using System;
using HotelsReservation.Domain.Entities;
using HotelsReservation.Repository.UnitOfWork;
using HotelsReservation.Services.Contracts;

namespace HotelsReservation.Services.Implementations
{
	public class RoomService : IRoomService
	{
        private readonly IUnitOfWork _unitOfWork;

		public RoomService(IUnitOfWork unitOfWork)
		{
            _unitOfWork = unitOfWork;
		}

        public async Task<Room> CreateRoom(Room room)
        {
            try
            {
                await _unitOfWork.RoomRepository.AddAsync(room);
                await _unitOfWork.SaveAsync();
                return room;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<Room> ReadRoom(int id)
        {
            try
            {
                return await _unitOfWork.RoomRepository.FindAsync(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task DeleteRoom(int id)
        {
            try
            {
                await _unitOfWork.RoomRepository.Delete(id);
                await _unitOfWork.SaveAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}

