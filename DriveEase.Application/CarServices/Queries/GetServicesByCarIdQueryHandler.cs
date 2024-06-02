using DriveEase.Application.Common.Interfaces;
using DriveEase.Shared.CarServices.Dtos;
using DriveEase.Shared.CarServices.Queries;
using Mapster;
using MediatR;

namespace DriveEase.Application.CarServices.Queries
{
	public class GetServicesByCarIdQueryHandler : IRequestHandler<GetServicesByCarIdQuery, IEnumerable<ServiceHistoryDto>>
	{
		private readonly IServiceHistoryService _serviceHistory;

		public GetServicesByCarIdQueryHandler(IServiceHistoryService serviceHistory)
		{
			_serviceHistory = serviceHistory;
		}
		public async Task<IEnumerable<ServiceHistoryDto>> Handle(GetServicesByCarIdQuery request, CancellationToken cancellationToken)
		{
			var services = await _serviceHistory.GetServicesByCarId(request.CarId);
			return services.Adapt<IEnumerable<ServiceHistoryDto>>();
		}
	}
}
