using DriveEase.Application.Common.Interfaces;
using DriveEase.Shared.Clients.Dtos;
using DriveEase.Shared.Clients.Queries;
using Mapster;
using MediatR;

namespace DriveEase.Application.Clients.Queries
{
	public class GetClientByIdQueryHandler : IRequestHandler<GetClientByIdQuery, ClientDto>
	{
		private readonly IClientService _clientService;

		public GetClientByIdQueryHandler(IClientService clientService)
        {
			_clientService = clientService;
		}
        public async Task<ClientDto> Handle(GetClientByIdQuery request, CancellationToken cancellationToken)
		{
			var client = await _clientService.GetClientByIdAsync(request.Id);
			
			if (client == null) 
				return null;

			return client.Adapt<ClientDto>();
		}
	}
}
