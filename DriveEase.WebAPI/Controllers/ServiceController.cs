using DriveEase.Shared.CarServices.Commands;
using DriveEase.Shared.CarServices.Queries;
using Microsoft.AspNetCore.Mvc;

namespace DriveEase.WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ServiceController : BaseController
	{
		[HttpGet]
		public async Task<IActionResult> GetServices()
		{
			if (!ModelState.IsValid)
				return BadRequest(ModelState);

			return Ok(await Mediator.Send(new GetAllServicesQuery()));
		}

		[HttpGet("car/{carId}")]
		public async Task<IActionResult> GetServicesByCarId(int carId)
		{
			if (!ModelState.IsValid)
				return BadRequest(ModelState);

			var result = await Mediator.Send(new GetServicesByCarIdQuery { CarId = carId });

			if (result == null)
				return NotFound();

			return Ok(result);
		}

		[HttpPost]
		public async Task<IActionResult> CreateService(CreateServiceCommand command)
		{
			if (!ModelState.IsValid)
				return BadRequest(ModelState);

			var result = await Mediator.Send(command);

			return Ok(result);
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> UpdateService(UpdateServiceCommand command)
		{
			if (!ModelState.IsValid)
				return BadRequest(ModelState);

			var result = await Mediator.Send(command);

			if (result == null)
				return NotFound();

			return Ok(result);
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteService(int id)
		{
			if (!ModelState.IsValid)
				return BadRequest(ModelState);

			var result = await Mediator.Send(new DeleteServiceCommand { ServiceId = id });

			if (!result)
				return NotFound();

			return Ok();
		}

	}
}
