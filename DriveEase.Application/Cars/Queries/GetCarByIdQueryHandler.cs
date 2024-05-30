using DriveEase.Application.Common.Interfaces;
using DriveEase.Shared.Cars.Queries;
using Mapster;
using MediatR;

namespace DriveEase.Application.Cars.Queries
{
	public class GetCarByIdQueryHandler : IRequestHandler<GetCarByIdQuery, CarDto>
	{
		private readonly ICarService _carService;

		public GetCarByIdQueryHandler(ICarService carService)
        {
			_carService = carService;
		}
        public async Task<CarDto> Handle(GetCarByIdQuery request, CancellationToken cancellationToken)
		{
			var result = await _carService.GetCarByIdAsync(request.Id);

			if (result == null)
				return null;

			return result.Adapt<CarDto>();
		}
	}
}
