using DriveEase.Shared.CarServices.Commands;
using DriveEase.Shared.CarServices.Queries;
using Microsoft.AspNetCore.Mvc;

namespace DriveEase.WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ServiceController : BaseController
	{
		private readonly ILogger<ServiceController> _logger;

		public ServiceController(ILogger<ServiceController> logger)
		{
			_logger = logger;
		}

		[HttpGet]
		public async Task<IActionResult> GetServices()
		{
			_logger.LogInformation("Getting all services");

			if (!ModelState.IsValid)
			{
				_logger.LogWarning("Invalid model state getting all services");
				return BadRequest(ModelState);
			}

			return Ok(await Mediator.Send(new GetAllServicesQuery()));
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetServiceById(int id)
		{
			_logger.LogInformation($"Getting service by ID: {id}");

			if (!ModelState.IsValid)
			{
				_logger.LogWarning("Invalid model state getting service by ID.");
				return BadRequest(ModelState);
			}

			var result = await Mediator.Send(new GetServiceByIdQuery { Id = id });

			if (result == null)
			{
				_logger.LogWarning($"Service with ID: {id} not found.");
				return NotFound();
			}

			return Ok(result);
		}

		[HttpGet("car/{carId}")]
		public async Task<IActionResult> GetServicesByCarId(int carId)
		{
			_logger.LogInformation($"Getting services by car ID: {carId}");

			if (!ModelState.IsValid)
			{
				_logger.LogWarning("Invalid model state getting service by car ID.");
				return BadRequest(ModelState);
			}

			var result = await Mediator.Send(new GetServicesByCarIdQuery { CarId = carId });

			if (result == null)
			{
				_logger.LogWarning($"Car with ID: {carId} not found.");
				return NotFound();
			}

			return Ok(result);
		}

		[HttpPost]
		public async Task<IActionResult> CreateService(CreateServiceCommand command)
		{
			_logger.LogInformation("Creating a new service");

			if (!ModelState.IsValid)
				return BadRequest(ModelState);

			var result = await Mediator.Send(command);

			if (result == null)
			{
				_logger.LogWarning("Error creating a new service.");
			}

			return Ok(result);
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> UpdateService(UpdateServiceCommand command)
		{
			_logger.LogInformation("Updating service.");

			if (!ModelState.IsValid)
				return BadRequest(ModelState);

			var result = await Mediator.Send(command);

			if (result == null)
			{
				_logger.LogWarning($"Error updating service.");
			}

			return Ok(result);
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteService(int id)
		{
			_logger.LogInformation($"Deleting service with ID: {id}");

			if (!ModelState.IsValid)
				return BadRequest(ModelState);

			var result = await Mediator.Send(new DeleteServiceCommand { ServiceId = id });

			if (result == null)
			{
				_logger.LogWarning($"Error deleting service with ID: {id}");
			}

			return Ok();
		}

	}
}
