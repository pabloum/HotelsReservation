using HotelsReservation.Domain.Entities;

namespace HotelsReservation.Services.Contracts
{
    public interface IHotelService : IService
    {
        Task<IEnumerable<Hotel>> GetAll();
		Task<Hotel> CreateHotel(Hotel hotel);
        Task<Hotel> ReadHotel(int id);
        Task DeleteHotel(int id);
    }
}

