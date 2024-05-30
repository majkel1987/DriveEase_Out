using DriveEase.Shared.Clients.Dtos;
using MediatR;

namespace DriveEase.Shared.Clients.Queries
{
	public class GetClientsQuery : IRequest<IEnumerable<ClientDto>>
	{
	}
}
