using MediatR;

namespace DriveEase.Shared.Clients.Commands
{
	public class DeleteClientCommand : IRequest<bool>
	{
		public int Id { get; set; }
	}
}
