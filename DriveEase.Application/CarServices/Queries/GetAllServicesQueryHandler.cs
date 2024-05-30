using DriveEase.Application.Common.Interfaces;
using DriveEase.Shared.CarServices.Dtos;
using DriveEase.Shared.CarServices.Queries;
using Mapster;
using MediatR;

namespace DriveEase.Application.CarServices.Queries
{
	public class GetAllServicesQueryHandler : IRequestHandler<GetAllServicesQuery, IEnumerable<ServiceHistoryDto>>
	{
		private readonly IServiceHistoryService _serviceHistory;

		public GetAllServicesQueryHandler(IServiceHistoryService serviceHistory)
		{
			_serviceHistory = serviceHistory;
		}
		public async Task<IEnumerable<ServiceHistoryDto>> Handle(GetAllServicesQuery request, CancellationToken cancellationToken)
		{
			var services = await _serviceHistory.GetAllServices();
			return services.Adapt<IEnumerable<ServiceHistoryDto>>();
		}
	}
}
