using DriveEase.Application.Common.Interfaces;
using DriveEase.Domain.Entities;
using Mapster;
using MediatR;

namespace DriveEase.Application.Cars.Queries
{
	public class GetCarsQueryHandler : IRequestHandler<GetCarsQuery, IEnumerable<CarDto>>
	{
		private readonly ICarService _carService;

		public GetCarsQueryHandler(ICarService carService)
        {
			_carService = carService;
		}
        public async Task<IEnumerable<CarDto>> Handle(GetCarsQuery request, CancellationToken cancellationToken)
		{
			var cars = await _carService.GetCarsAsync();
			return cars.Adapt<IEnumerable<CarDto>>();
		}
	}

}
