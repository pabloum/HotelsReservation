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
    }
}

