using MediatR;

namespace DriveEase.Shared.CarServices.Commands
{
	public class DeleteServiceCommand : IRequest<bool>
	{
		public int ServiceId { get; set; }
	}
}
