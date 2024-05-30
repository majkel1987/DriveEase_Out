using DriveEase.Application.Common.Interfaces;
using DriveEase.Shared.Cars.Commands;
using MediatR;

namespace DriveEase.Application.Cars.Commands
{
	public class DeleteCarCommandHandler : IRequestHandler<DeleteCarCommand, bool>
	{
		private readonly ICarService _carService;

		public DeleteCarCommandHandler(ICarService carService)
		{
			_carService = carService;
		}

		public async Task<bool> Handle(DeleteCarCommand request, CancellationToken cancellationToken)
		{
			await _carService.DeleteCarAsync(request.Id);
			return true;
		}
	}
}
