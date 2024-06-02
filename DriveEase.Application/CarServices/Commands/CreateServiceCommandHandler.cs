using DriveEase.Application.Common.Interfaces;
using DriveEase.Domain.Entities;
using DriveEase.Shared.CarServices.Commands;
using DriveEase.Shared.CarServices.Dtos;
using Mapster;
using MediatR;

namespace DriveEase.Application.CarServices.Commands
{
	public class CreateServiceCommandHandler : IRequestHandler<CreateServiceCommand, CreateServiceDto>
	{
		private readonly IServiceHistoryService _serviceHistory;

		public CreateServiceCommandHandler(IServiceHistoryService serviceHistory)
		{
			_serviceHistory = serviceHistory;
		}
		public async Task<CreateServiceDto> Handle(CreateServiceCommand request, CancellationToken cancellationToken)
		{
			var newService = request.Adapt<ServiceHistory>();
			var result = await _serviceHistory.CreateServiceAsync(newService);
			return result.Adapt<CreateServiceDto>();
		}
	}
}
