using System;
namespace HotelsReservation.Api.Controllers
{
	public class ReservationController : BaseController
	{
		private IReservationService _reservationService;

		public ReservationController(IReservationService reservationService)
		{
			_reservationService = reservationService;
        }
	}
}

