using System;
using HotelsReservation.Services.Contracts;

namespace HotelsReservation.Api.Installers
{
	public static class PopulateInMemoryDb
	{
		public static async void Populate(WebApplication app)
		{
			using (var scope = app.Services.CreateScope())
			{
				var hotelService = scope.ServiceProvider.GetRequiredService<IHotelService>();
				var roomService = scope.ServiceProvider.GetRequiredService<IRoomService>();

				// populate
			}
		}
	}
}

