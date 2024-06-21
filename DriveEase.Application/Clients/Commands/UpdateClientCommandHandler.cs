using DriveEase.Application.Common.Interfaces;
using DriveEase.Domain.Entities;
using DriveEase.Shared.Clients.Commands;
using DriveEase.Shared.Clients.Dtos;
using DriveEase.Shared.Mappers;
using MediatR;

namespace DriveEase.Application.Clients.Commands
{
	public class UpdateClientCommandHandler : IRequestHandler<UpdateClientCommand, UpdateClientDto>
	{
		private readonly IClientService _clientService;

		public UpdateClientCommandHandler(IClientService clientService)
		{
			_clientService = clientService;
		}
		public async Task<UpdateClientDto> Handle(UpdateClientCommand request, CancellationToken cancellationToken)
		{
			var updatedClient = new Client
			{
				CompanyName = request.CompanyName,
				IsDeleted = false,
				IsPrivateAccount = request.IsPrivateAccount,
				NipNumber = request.NipNumber,
				FirstName = request.FirstName,
				LastName = request.LastName,
				DateOfBirth = request.DateOfBirth,
				Email = request.Email,
				PhoneNumber = request.PhoneNumber,
				DriverLicenseNumber = request.DriverLicenseNumber,
				Notes = request.Notes,
				Address = new Address
				{
					City = request.Address.City,
					Street = request.Address.Street,
					PostalCode = request.Address.PostalCode,
					Country = request.Address.Country
				}
			};
			var result = await _clientService.UpdateClientAsync(request.Id, updatedClient);

			if (result == null)
				return null;

			return result.ToUpdateClientDto();
		}
	}
}
