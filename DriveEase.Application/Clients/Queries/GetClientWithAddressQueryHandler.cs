using DriveEase.Application.Common.Interfaces;
using DriveEase.Shared.Clients.Dtos;
using DriveEase.Shared.Clients.Queries;
using Mapster;
using MediatR;

namespace DriveEase.Application.Clients.Queries
{
	public class GetClientWithAddressQueryHandler : IRequestHandler<GetClientWithAddressQuery, ClientDto>
	{
		private readonly IClientService _clientService;

		public GetClientWithAddressQueryHandler(IClientService clientService)
		{
			_clientService = clientService;
		}
		public async Task<ClientDto> Handle(GetClientWithAddressQuery request, CancellationToken cancellationToken)
		{
			var result = await _clientService.GetClientWithAddress(request.Id);

			if (result == null)
				return null;

			return result.Adapt<ClientDto>();
		}
	}
}
