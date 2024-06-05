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
		private readonly ILogger<CarController> _logger;

		public CarController(ILogger<CarController> logger)
		{
			_logger = logger;
		}

		[HttpGet]
		public async Task<IActionResult> GetCars()
		{
			_logger.LogInformation("Getting all cars");

			if (!ModelState.IsValid)
			{
				_logger.LogWarning("Invalid model state getting all cars");
				return BadRequest(ModelState);
			}

			return Ok(await Mediator.Send(new GetCarsQuery()));
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetCar(int id)
		{
			_logger.LogInformation($"Getting car by ID: {id}");

			if (!ModelState.IsValid)
			{
				_logger.LogWarning("Invalid model state getting car by ID.");
				return BadRequest(ModelState);
			}

			var result = await Mediator.Send(new GetCarByIdQuery { Id = id });

			if (result == null)
			{
				_logger.LogWarning($"Car with ID: {id} not found.");
				return NotFound();
			}

			return Ok(result);
		}

		[HttpGet("brand/{brand}")]
		public async Task<IActionResult> GetCarByBrand(string brand)
		{
			_logger.LogInformation($"Getting car by brand: {brand}");

			if (!ModelState.IsValid)
				return BadRequest(ModelState);

			var result = await Mediator.Send(new GetCarByBrandQuery { Brand = brand });

			if (result == null)
			{
				_logger.LogWarning($"Car with brand: {brand} not found.");
				return NotFound();
			}

			return Ok(result);
		}

		[HttpPost]
		public async Task<IActionResult> CreateCar(CreateCarCommand command)
		{
			_logger.LogInformation("Creating car");

			if (!ModelState.IsValid)
				return BadRequest(ModelState);

			var result = await Mediator.Send(command);

			if (result == null)
			{
				_logger.LogWarning("Error creating a new service.");
			}

			return CreatedAtAction(nameof(GetCar), new { id = result.Id }, result);
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> UpdateCar(UpdateCarCommand command)
		{
			_logger.LogInformation($"Updating car with ID: {command.Id}");

			if (!ModelState.IsValid)
				return BadRequest(ModelState);

			var result = await Mediator.Send(command);

			if (result == null)
			{
				_logger.LogWarning($"Car with ID: {command.Id} not found.");
				return NotFound();
			}

			return Ok(result);
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteCar(int id)
		{
			_logger.LogInformation($"Deleting car with ID: {id}");
			if (!ModelState.IsValid)
				return BadRequest(ModelState);

			var result = await Mediator.Send(new DeleteCarCommand { Id = id });

			if (!result)
			{
				_logger.LogWarning($"Error deleting car with ID: {id}");
				return NotFound();
			}

			return NoContent();
		}

		[HttpGet("service-history/{id}")]
		public async Task<IActionResult> GetCarWithServiceHistory(int id)
		{
			_logger.LogInformation($"Getting car with service history by ID: {id}");

			if (!ModelState.IsValid)
				return BadRequest(ModelState);

			var result = await Mediator.Send(new GetCarWithServiceHistoryQuery { Id = id });

			if (result == null)
			{
				_logger.LogWarning($"Car with ID: {id} not found.");
				return NotFound();
			}

			return Ok(result);
		}
	}
}
