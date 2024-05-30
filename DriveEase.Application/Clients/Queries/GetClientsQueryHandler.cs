using DriveEase.Application.Common.Interfaces;
using DriveEase.Shared.Clients.Dtos;
using DriveEase.Shared.Clients.Queries;
using Mapster;
using MediatR;

namespace DriveEase.Application.Clients.Queries
{
	public class GetClientsQueryHandler : IRequestHandler<GetClientsQuery, IEnumerable<ClientDto>>
	{
		private readonly IClientService _clientService;

		public GetClientsQueryHandler(IClientService clientService)
        {
			_clientService = clientService;
		}
        public async Task<IEnumerable<ClientDto>> Handle(GetClientsQuery request, CancellationToken cancellationToken)
		{
			var clients = await _clientService.GetClientsAsync();
			return clients.Adapt<IEnumerable<ClientDto>>();

		}
	}
}
