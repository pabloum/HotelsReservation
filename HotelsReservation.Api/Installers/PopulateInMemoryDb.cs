using System;
using HotelsReservation.Services.Contracts;
using HotelsReservation.Services.Implementations;

namespace HotelsReservation.Api.Installers
{
	public static class PopulateInMemoryDb
	{
		public static async Task Populate(WebApplication app)
		{
			using (var scope = app.Services.CreateScope())
			{
				var hotelService = scope.ServiceProvider.GetRequiredService<IHotelService>();
				var roomService = scope.ServiceProvider.GetRequiredService<IRoomService>();

                // Hotel
                await PopulateHotels(hotelService);
                await PopulateRooms(roomService, hotelService);
            }
        }
        private async static Task PopulateHotels(IHotelService hotelService)
		{
            await hotelService.CreateHotel(new Domain.Entities.Hotel
            {
                Name = "Dan Carlton",
                City = "Medellin",
                Country = "Colombia",
                IsActive = true
            });

            await hotelService.CreateHotel(new Domain.Entities.Hotel
            {
                Name = "Hilton",
                City = "Medellin",
                Country = "Colombia",
                IsActive = true
            });
        }

        private async static Task PopulateRooms(IRoomService roomService, IHotelService hotelService)
        {
            await roomService.CreateRoom(new Domain.Entities.Room
            {
                Number = "1208",
                HotelId = 1,
                Hotel = await hotelService.ReadHotel(1),
                RoomType = "Simple",
                IsActive = true
            });

            await roomService.CreateRoom(new Domain.Entities.Room
            {
                Number = "1308",
                HotelId = 1,
                Hotel = await hotelService.ReadHotel(1),
                RoomType = "Simple",
                IsActive = true
            });

            await roomService.CreateRoom(new Domain.Entities.Room
            {
                Number = "1408",
                HotelId = 1,
                Hotel = await hotelService.ReadHotel(1),
                RoomType = "Penthouse",
                IsActive = true
            });

            await roomService.CreateRoom(new Domain.Entities.Room
            {
                Number = "1508",
                HotelId = 2,
                Hotel = await hotelService.ReadHotel(2),
                RoomType = "Penthouse",
                IsActive = true
            });

            await roomService.CreateRoom(new Domain.Entities.Room
            {
                Number = "1608",
                HotelId = 2,
                Hotel = await hotelService.ReadHotel(2),
                RoomType = "Penthouse",
                IsActive = true
            });
        }

    }
}

