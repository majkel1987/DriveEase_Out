using DriveEase.Application.Common.Interfaces;
using DriveEase.Shared.CarServices.Dtos;
using DriveEase.Shared.CarServices.Queries;
using Mapster;
using MediatR;

namespace DriveEase.Application.CarServices.Queries
{
	public class GetServiceByIdQueryHandler : IRequestHandler<GetServiceByIdQuery, ServiceHistoryDto>
	{
		private readonly IServiceHistoryService _serviceHistory;

		public GetServiceByIdQueryHandler(IServiceHistoryService serviceHistory)
		{
			_serviceHistory = serviceHistory;
		}
		public async Task<ServiceHistoryDto> Handle(GetServiceByIdQuery request, CancellationToken cancellationToken)
		{
			var service = await _serviceHistory.GetServiceById(request.Id);

			if (service == null)
			{
				return null;
			}

			return service.Adapt<ServiceHistoryDto>();
		}
	}
}
