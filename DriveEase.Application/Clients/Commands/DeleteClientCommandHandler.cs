using DriveEase.Application.Common.Interfaces;
using DriveEase.Shared.Clients.Commands;
using MediatR;

namespace DriveEase.Application.Clients.Commands
{
	public class DeleteClientCommandHandler : IRequestHandler<DeleteClientCommand, bool>
	{
		private readonly IClientService _clientService;

		public DeleteClientCommandHandler(IClientService clientService)
        {
			_clientService = clientService;
		}
        public async Task<bool> Handle(DeleteClientCommand request, CancellationToken cancellationToken)
		{
			await _clientService.DeleteClientAsync(request.Id);
			return true;
		}
	}
}
