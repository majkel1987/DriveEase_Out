using DriveEase.Application.Common.Interfaces;
using DriveEase.Shared.Cars.Queries;
using Mapster;
using MediatR;

namespace DriveEase.Application.Cars.Queries
{
	public class GetCarByBrandQueryHandler : IRequestHandler<GetCarByBrandQuery, IEnumerable<CarDto>>
	{
		private readonly ICarService _carService;

		public GetCarByBrandQueryHandler(ICarService carService)
        {
			_carService = carService;
		}

		public async Task<IEnumerable<CarDto>> Handle(GetCarByBrandQuery request, CancellationToken cancellationToken)
		{
			var cars = await _carService.GetCarByBrandAsync(request.Brand);
			return cars.Adapt<IEnumerable<CarDto>>();
		}
	}
}
