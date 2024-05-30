using MediatR;

namespace DriveEase.Shared.Cars.Commands
{
	public class DeleteCarCommand : IRequest<bool>
	{
        public int Id { get; set; }
    }
}
