using DriveEase.Application.Cars.Queries;
using DriveEase.Shared.Cars.Commands;
using DriveEase.Shared.Cars.Queries;
using Microsoft.AspNetCore.Mvc;

namespace DriveEase.WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CarController : BaseController
	{
		[HttpGet]
		public async Task<IActionResult> GetCars()
		{
			if (!ModelState.IsValid)
				return BadRequest(ModelState);

			return Ok(await Mediator.Send(new GetCarsQuery()));
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetCar(int id)
		{
			if (!ModelState.IsValid)
				return BadRequest(ModelState);

			var result = await Mediator.Send(new GetCarByIdQuery { Id = id });

			if (result == null)
				return NotFound();

			return Ok(result);
		}

		[HttpGet("brand/{brand}")]
		public async Task<IActionResult> GetCarByBrand(string brand)
		{
			if (!ModelState.IsValid)
				return BadRequest(ModelState);

			var result = await Mediator.Send(new GetCarByBrandQuery { Brand = brand });

			if (result == null)
				return NotFound();

			return Ok(result);
		}

		[HttpPost]
		public async Task<IActionResult> CreateCar(CreateCarCommand command)
		{
			if (!ModelState.IsValid)
				return BadRequest(ModelState);

			var result = await Mediator.Send(command);

			return CreatedAtAction(nameof(GetCar), new { id = result.Id }, result);
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> UpdateCar(UpdateCarCommand command)
		{
			if (!ModelState.IsValid)
				return BadRequest(ModelState);

			var result = await Mediator.Send(command);

			if (result == null)
				return NotFound();

			return Ok(result);
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteCar(int id)
		{
			if (!ModelState.IsValid)
				return BadRequest(ModelState);

			var result = await Mediator.Send(new DeleteCarCommand { Id = id });

			if (!result)
				return NotFound();

			return NoContent();
		}

		[HttpGet("service-history/{id}")]
		public async Task<IActionResult> GetCarWithServiceHistory(int id)
		{
			if (!ModelState.IsValid)
				return BadRequest(ModelState);

			var result = await Mediator.Send(new GetCarWithServiceHistoryQuery { Id = id });

			if (result == null)
				return NotFound();

			return Ok(result);
		}
	}
}
