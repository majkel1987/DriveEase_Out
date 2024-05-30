using DriveEase.Application.Common.Interfaces;
using DriveEase.Domain.Entities;
using DriveEase.Shared.Cars.Commands;
using DriveEase.Shared.Cars.Dtos;
using Mapster;
using MediatR;

namespace DriveEase.Application.Cars.Commands
{
	public class CreateCarCommandHandler : IRequestHandler<CreateCarCommand, CreateCarDto>
	{
		private readonly ICarService _carService;

		public CreateCarCommandHandler(ICarService carService)
        {
			_carService = carService;
		}
        public async Task<CreateCarDto> Handle(CreateCarCommand request, CancellationToken cancellationToken)
		{
			var newCar = request.Adapt<Car>();
			var result = await _carService.CreateCarAsync(newCar);
			return result.Adapt<CreateCarDto>();
		}
	}
}
