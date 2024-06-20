using DriveEase.Shared.Clients.Dtos;
using MediatR;

namespace DriveEase.Shared.Clients.Queries
{
	public class GetClientWithAddressQuery : IRequest<ClientDto>
	{
		public int Id { get; set; }
	}
}
