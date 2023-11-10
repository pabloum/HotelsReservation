using System;
using Microsoft.AspNetCore.Mvc;

namespace HotelsReservation.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseController : ControllerBase
	{
		public BaseController()
		{
		}

		[HttpGet]
		public IActionResult Success(string message = "")
		{
			return Ok(message);
		}
	}
}

