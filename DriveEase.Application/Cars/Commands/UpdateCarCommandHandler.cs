using DriveEase.Application.Common.Interfaces;
using DriveEase.Domain.Entities;
using DriveEase.Shared.Cars.Commands;
using DriveEase.Shared.Cars.Dtos;
using Mapster;
using MediatR;

namespace DriveEase.Application.Cars.Commands
{
	public class UpdateCarCommandHandler : IRequestHandler<UpdateCarCommand, UpdateCarDto>
	{
		private readonly ICarService _carService;

		public UpdateCarCommandHandler(ICarService carService)
        {
			_carService = carService;
		}
        public async Task<UpdateCarDto> Handle(UpdateCarCommand request, CancellationToken cancellationToken)
		{
			var updatedCar = request.Adapt<Car>();
			var result = await _carService.UpdateCarAsync(request.Id, updatedCar);
			
			if (result == null)
				return null;
			
			return result.Adapt<UpdateCarDto>();
		}
	}
}
