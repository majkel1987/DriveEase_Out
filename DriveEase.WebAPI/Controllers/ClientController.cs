using DriveEase.Shared.Clients.Commands;
using DriveEase.Shared.Clients.Queries;
using Microsoft.AspNetCore.Mvc;

namespace DriveEase.WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ClientController : BaseController
	{
		[HttpGet]
		public async Task<IActionResult> GetClients()
		{
			if (!ModelState.IsValid)
				return BadRequest(ModelState);

			return Ok(await Mediator.Send(new GetClientsQuery()));
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetClient(int id)
		{
			if (!ModelState.IsValid)
				return BadRequest(ModelState);

			var result = await Mediator.Send(new GetClientByIdQuery { Id = id });

			if (result == null)
				return NotFound();

			return Ok(result);
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteClient(int id)
		{
			if (!ModelState.IsValid)
				return BadRequest(ModelState);

			var result = await Mediator.Send(new DeleteClientCommand { Id = id });

			if (!result)
				return NotFound();

			return NoContent();
		}

		[HttpPost]
		public async Task<IActionResult> CreateClient(CreateClientCommand command)
		{
			if (!ModelState.IsValid)
				return BadRequest(ModelState);

			var result = await Mediator.Send(command);
			return CreatedAtAction(nameof(GetClient), new { id = result.Id }, result);
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> UpdateClient(int id, UpdateClientCommand command)
		{
			if (!ModelState.IsValid)
				return BadRequest(ModelState);
			
			var result = await Mediator.Send(command);

			if (result == null)
				return NotFound();

			return Ok(result);
		}
	}
}
