using DriveEase.Application.Common.Interfaces;
using DriveEase.Domain.Entities;
using DriveEase.Shared.Clients.Commands;
using DriveEase.Shared.Clients.Dtos;
using Mapster;
using MediatR;

namespace DriveEase.Application.Clients.Commands
{
	public class CreateClientCommandHandler : IRequestHandler<CreateClientCommand, CreateClientDto>
	{
		private readonly IClientService _clientService;

		public CreateClientCommandHandler(IClientService clientService)
        {
			_clientService = clientService;
		}
        public async Task<CreateClientDto> Handle(CreateClientCommand request, CancellationToken cancellationToken)
		{
			var newClient = request.Adapt<Client>();
			var result = await _clientService.CreateClientAsync(newClient);
			return result.Adapt<CreateClientDto>();
		}
	}
}
