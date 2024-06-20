using DriveEase.Application.Common.Interfaces;
using DriveEase.Domain.Entities;
using DriveEase.Shared.Clients.Commands;
using DriveEase.Shared.Clients.Dtos;
using DriveEase.Shared.Mappers;
using Mapster;
using MediatR;

namespace DriveEase.Application.Clients.Commands
{
	public class UpdateClientCommandHandler : IRequestHandler<UpdateClientCommand, UpdateClientDto>
	{
		private readonly IClientService _clientService;

		public UpdateClientCommandHandler(IClientService clientService)
		{
			_clientService = clientService;
		}
		public async Task<UpdateClientDto> Handle(UpdateClientCommand request, CancellationToken cancellationToken)
		{
			var updatedClient = request.Adapt<Client>();
			var result = await _clientService.UpdateClientAsync(request.Id, updatedClient);

			if (result == null)
				return null;

			return result.ToUpdateClientDto();
		}
	}
}
