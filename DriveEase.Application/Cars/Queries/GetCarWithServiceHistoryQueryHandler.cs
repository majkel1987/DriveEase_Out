using DriveEase.Application.Common.Interfaces;
using DriveEase.Shared.Cars.Queries;
using Mapster;
using MediatR;

namespace DriveEase.Application.Cars.Queries
{
	public class GetCarWithServiceHistoryQueryHandler : IRequestHandler<GetCarWithServiceHistoryQuery, CarDto>
	{
		private readonly ICarService _carService;

		public GetCarWithServiceHistoryQueryHandler(ICarService carService)
        {
			_carService = carService;
		}
        public async Task<CarDto> Handle(GetCarWithServiceHistoryQuery request, CancellationToken cancellationToken)
		{
			var result = await _carService.GetCarWithServiceHistoryById(request.Id);

			if (result == null) 
				return null;

			return result.Adapt<CarDto>();
		}
	}
}
