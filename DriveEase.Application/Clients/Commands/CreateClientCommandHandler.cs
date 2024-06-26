﻿using DriveEase.Application.Common.Interfaces;
using DriveEase.Domain.Entities;
using DriveEase.Shared.Clients.Commands;
using DriveEase.Shared.Clients.Dtos;
using DriveEase.Shared.Mappers;
using MediatR;

namespace DriveEase.Application.Clients.Commands
{
	public class CreateClientCommandHandler : IRequestHandler<CreateClientCommand, CreateClientDto>
	{
		private readonly IClientService _clientService;

		public CreateClientCommandHandler(IClientService clientService)
		{
			_clientService = clientService;
		}
		public async Task<CreateClientDto> Handle(CreateClientCommand request, CancellationToken cancellationToken)
		{
			var newClient = new Client
			{
				CompanyName = request.CompanyName,
				IsDeleted = request.IsDeleted,
				IsPrivateAccount = request.IsPrivateAccount,
				NipNumber = request.NipNumber,
				FirstName = request.FirstName,
				LastName = request.LastName,
				DateOfBirth = request.DateOfBirth,
				Email = request.Email,
				PhoneNumber = request.PhoneNumber,
				DriverLicenseNumber = request.DriverLicenseNumber,
				Notes = request.Notes
			};
			var result = await _clientService.CreateClientAsync(newClient);
			return result.ToCreateClientDto();
		}
	}
}
