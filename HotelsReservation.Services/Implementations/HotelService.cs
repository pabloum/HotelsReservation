using System;
using HotelsReservation.Domain.Entities;
using HotelsReservation.Repository.UnitOfWork;
using HotelsReservation.Services.Contracts;

namespace HotelsReservation.Services.Implementations
{
	public class HotelService : IHotelService
	{
        private readonly IUnitOfWork _unitOfWork;

        public HotelService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Hotel>> GetAll()
        {
            return await _unitOfWork.HotelRepository.GetAllAsync(null, null, "Rooms");
        }

        public async Task<Hotel> CreateHotel(Hotel hotel)
        {
            try
            {
                await _unitOfWork.HotelRepository.AddAsync(hotel);
                await _unitOfWork.SaveAsync();
                return hotel;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<Hotel> ReadHotel(int id)
        {
            try
            {
                return await _unitOfWork.HotelRepository.FindAsync(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task DeleteHotel(int id)
        {
            try
            {
                await _unitOfWork.HotelRepository.Delete(id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}

