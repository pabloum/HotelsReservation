using HotelsReservation.Domain.Entities;

namespace HotelsReservation.Services.Contracts
{
	public interface IRoomService : IService
    {
        Task<IEnumerable<Room>> GetAll();
        Task<Room> CreateRoom(Room room);
        Task<Room> ReadRoom(int id);
        Task DeleteRoom(int id);
    }
}

