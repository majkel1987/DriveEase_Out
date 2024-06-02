using DriveEase.Application.Common.Interfaces;
using DriveEase.Shared.CarServices.Commands;
using MediatR;

namespace DriveEase.Application.CarServices.Commands
{
	public class DeleteServiceCommandHandler : IRequestHandler<DeleteServiceCommand, bool>
	{
		private readonly IServiceHistoryService _serviceHistory;

		public DeleteServiceCommandHandler(IServiceHistoryService serviceHistory)
		{
			_serviceHistory = serviceHistory;
		}
		public async Task<bool> Handle(DeleteServiceCommand request, CancellationToken cancellationToken)
		{
			return await _serviceHistory.DeleteService(request.ServiceId);
		}
	}
}
