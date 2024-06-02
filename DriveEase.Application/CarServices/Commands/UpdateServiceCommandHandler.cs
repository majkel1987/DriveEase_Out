using DriveEase.Application.Common.Interfaces;
using DriveEase.Domain.Entities;
using DriveEase.Shared.CarServices.Commands;
using DriveEase.Shared.CarServices.Dtos;
using Mapster;
using MediatR;

namespace DriveEase.Application.CarServices.Commands
{
	public class UpdateServiceCommandHandler : IRequestHandler<UpdateServiceCommand, UpdateServiceDto>
	{
		private readonly IServiceHistoryService _serviceHistory;

		public UpdateServiceCommandHandler(IServiceHistoryService serviceHistory)
		{
			_serviceHistory = serviceHistory;
		}
		public async Task<UpdateServiceDto> Handle(UpdateServiceCommand request, CancellationToken cancellationToken)
		{
			var serviceToUpdate = request.Adapt<ServiceHistory>();
			var result = await _serviceHistory.UpdateServiceAsync(serviceToUpdate, request.Id);

			if (result == null)
				return null;

			return result.Adapt<UpdateServiceDto>();
		}
	}
}
