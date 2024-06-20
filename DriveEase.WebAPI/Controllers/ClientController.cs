using DriveEase.Shared.Clients.Commands;
using DriveEase.Shared.Clients.Queries;
using Microsoft.AspNetCore.Mvc;

namespace DriveEase.WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ClientController : BaseController
	{
		private readonly ILogger<ClientController> _logger;

		public ClientController(ILogger<ClientController> logger)
		{
			_logger = logger;
		}

		[HttpGet]
		public async Task<IActionResult> GetClients()
		{
			_logger.LogInformation("Getting all clients");

			if (!ModelState.IsValid)
			{
				_logger.LogWarning("Invalid model state getting all clients");
				return BadRequest(ModelState);
			}

			return Ok(await Mediator.Send(new GetClientsQuery()));

		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetClient(int id)
		{
			_logger.LogInformation($"Getting client by ID: {id}");

			if (!ModelState.IsValid)
			{
				_logger.LogWarning("Invalid model state getting client by ID.");
				return BadRequest(ModelState);
			}

			var result = await Mediator.Send(new GetClientByIdQuery { Id = id });

			if (result == null)
			{
				_logger.LogWarning($"Client with ID: {id} not found.");
				return NotFound();
			}

			return Ok(result);
		}

		[HttpGet("address/{id}")]
		public async Task<IActionResult> GetClientWithAddress(int id)
		{
			_logger.LogInformation($"Getting client with address by ID: {id}");

			if (!ModelState.IsValid)
			{
				_logger.LogWarning("Invalid model state getting client with address by ID.");
				return BadRequest(ModelState);
			}

			var result = await Mediator.Send(new GetClientWithAddressQuery { Id = id });

			if (result == null)
			{
				_logger.LogWarning($"Client with address with ID: {id} not found.");
				return NotFound();
			}

			return Ok(result);
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteClient(int id)
		{
			_logger.LogInformation($"Deleting client by ID: {id}");

			if (!ModelState.IsValid)
			{
				_logger.LogWarning("Invalid model state deleting client by ID.");
				return BadRequest(ModelState);
			}

			var result = await Mediator.Send(new DeleteClientCommand { Id = id });

			if (!result)
			{
				_logger.LogWarning($"Client with ID: {id} not found.");
				return NotFound();
			}

			return NoContent();
		}

		[HttpPost("CreateClientWithAddress")]
		public async Task<IActionResult> CreateClientWithAddress(CreateClientWithAddressCommand command)
		{
			_logger.LogInformation("Creating a new client with address");

			if (!ModelState.IsValid)
			{
				_logger.LogWarning("Invalid model state creating a new client with address");
				return BadRequest(ModelState);
			}

			var result = await Mediator.Send(command);
			return Ok(result);
		}

		[HttpPost("CreateClient")]
		public async Task<IActionResult> CreateClient(CreateClientCommand command)
		{
			_logger.LogInformation("Creating a new client");

			if (!ModelState.IsValid)
			{
				_logger.LogWarning("Invalid model state creating a new client");
				return BadRequest(ModelState);
			}

			var result = await Mediator.Send(command);
			return Ok(result);
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> UpdateClient(int id, UpdateClientCommand command)
		{
			try
			{
				_logger.LogInformation($"Updating client with ID: {id}.");

				if (!ModelState.IsValid)
				{
					_logger.LogWarning("Invalid model state updating client by ID.");
					return BadRequest(ModelState);
				}

				if (id != command.Id)
				{
					_logger.LogWarning("Client ID mismatch.");
					return BadRequest("Client ID mismatch.");
				}

				var result = await Mediator.Send(command);
				return Ok(result);
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, $"Error updating client: {ex.Message}");
				return BadRequest();
			}
		}
	}
}
