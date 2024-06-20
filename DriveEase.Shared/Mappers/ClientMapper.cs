using DriveEase.Domain.Entities;
using DriveEase.Shared.Clients.Dtos;

namespace DriveEase.Shared.Mappers
{
	public static class ClientMapper
	{
		public static Client ToClientEntity(this ClientDto clientDto)
		{
			if (clientDto == null)
			{
				return null;
			}

			return new Client
			{
				Id = clientDto.Id,
				CompanyName = clientDto.CompanyName,
				IsDeleted = clientDto.IsDeleted,
				IsPrivateAccount = clientDto.IsPrivateAccount,
				NipNumber = clientDto.NipNumber,
				FirstName = clientDto.FirstName,
				LastName = clientDto.LastName,
				DateOfBirth = clientDto.DateOfBirth,
				Email = clientDto.Email,
				PhoneNumber = clientDto.PhoneNumber,
				DriverLicenseNumber = clientDto.DriverLicenseNumber,
				Notes = clientDto.Notes,
				Address = clientDto.Address.ToAddressEntity()
			};
		}

		public static Client ToClientEntityFromCreateDto(this CreateClientDto clientDto)
		{
			if (clientDto == null)
			{
				return null;
			}

			return new Client
			{
				CompanyName = clientDto.CompanyName,
				IsDeleted = clientDto.IsDeleted,
				IsPrivateAccount = clientDto.IsPrivateAccount,
				NipNumber = clientDto.NipNumber,
				FirstName = clientDto.FirstName,
				LastName = clientDto.LastName,
				DateOfBirth = clientDto.DateOfBirth,
				Email = clientDto.Email,
				PhoneNumber = clientDto.PhoneNumber,
				DriverLicenseNumber = clientDto.DriverLicenseNumber,
				Notes = clientDto.Notes,
				Address = clientDto.Address.ToAddressEntity()
			};
		}

		public static Client ToClientEntityFromUpdateDto(this UpdateClientDto clientDto)
		{
			if (clientDto == null)
			{
				return null;
			}

			return new Client
			{
				Id = clientDto.Id,
				CompanyName = clientDto.CompanyName,
				IsPrivateAccount = clientDto.IsPrivateAccount,
				NipNumber = clientDto.NipNumber,
				FirstName = clientDto.FirstName,
				LastName = clientDto.LastName,
				DateOfBirth = clientDto.DateOfBirth,
				Email = clientDto.Email,
				PhoneNumber = clientDto.PhoneNumber,
				DriverLicenseNumber = clientDto.DriverLicenseNumber,
				Notes = clientDto.Notes,
				Address = clientDto.Address.ToAddressEntity()
			};
		}

		public static ClientDto ToClientDto(this Client client)
		{
			if (client == null)
			{
				return null;
			}

			return new ClientDto
			{
				Id = client.Id,
				CompanyName = client.CompanyName,
				IsDeleted = client.IsDeleted,
				IsPrivateAccount = client.IsPrivateAccount,
				NipNumber = client.NipNumber,
				FirstName = client.FirstName,
				LastName = client.LastName,
				DateOfBirth = client.DateOfBirth,
				Email = client.Email,
				PhoneNumber = client.PhoneNumber,
				DriverLicenseNumber = client.DriverLicenseNumber,
				Notes = client.Notes,
				Address = client.Address.ToAddressDto()
			};
		}

		public static CreateClientDto ToCreateClientDto(this Client client)
		{
			if (client == null)
			{
				return null;
			}

			return new CreateClientDto
			{
				CompanyName = client.CompanyName,
				IsDeleted = client.IsDeleted,
				IsPrivateAccount = client.IsPrivateAccount,
				NipNumber = client.NipNumber,
				FirstName = client.FirstName,
				LastName = client.LastName,
				DateOfBirth = client.DateOfBirth,
				Email = client.Email,
				PhoneNumber = client.PhoneNumber,
				DriverLicenseNumber = client.DriverLicenseNumber,
				Notes = client.Notes,
				Address = client.Address.ToAddressDto()
			};
		}

		public static UpdateClientDto ToUpdateClientDto(this Client client)
		{
			if (client == null)
			{
				return null;
			}

			return new UpdateClientDto
			{
				Id = client.Id,
				CompanyName = client.CompanyName,
				IsPrivateAccount = client.IsPrivateAccount,
				NipNumber = client.NipNumber,
				FirstName = client.FirstName,
				LastName = client.LastName,
				DateOfBirth = client.DateOfBirth,
				Email = client.Email,
				PhoneNumber = client.PhoneNumber,
				DriverLicenseNumber = client.DriverLicenseNumber,
				Notes = client.Notes,
				Address = client.Address.ToAddressDto()
			};
		}

		public static CreateClientDto ToCreateClientDtoFromClientDto(this ClientDto clientDto)
		{
			if (clientDto == null)
			{
				return null;
			}

			return new CreateClientDto
			{
				CompanyName = clientDto.CompanyName,
				IsDeleted = clientDto.IsDeleted,
				IsPrivateAccount = clientDto.IsPrivateAccount,
				NipNumber = clientDto.NipNumber,
				FirstName = clientDto.FirstName,
				LastName = clientDto.LastName,
				DateOfBirth = clientDto.DateOfBirth,
				Email = clientDto.Email,
				PhoneNumber = clientDto.PhoneNumber,
				DriverLicenseNumber = clientDto.DriverLicenseNumber,
				Notes = clientDto.Notes,
				Address = clientDto.Address
			};
		}

		public static UpdateClientDto ToUpdateClientDtoFromCreateClientDto(this CreateClientDto clientDto)
		{
			if (clientDto == null)
			{
				return null;
			}

			return new UpdateClientDto
			{
				CompanyName = clientDto.CompanyName,
				IsPrivateAccount = clientDto.IsPrivateAccount,
				NipNumber = clientDto.NipNumber,
				FirstName = clientDto.FirstName,
				LastName = clientDto.LastName,
				DateOfBirth = clientDto.DateOfBirth,
				Email = clientDto.Email,
				PhoneNumber = clientDto.PhoneNumber,
				DriverLicenseNumber = clientDto.DriverLicenseNumber,
				Notes = clientDto.Notes,
				Address = clientDto.Address
			};
		}

		public static ClientDto ToClientDtoFromUpdateClientDto(this ClientDto clientDto)
		{
			if (clientDto == null)
			{
				return null;
			}

			return new ClientDto
			{
				Id = clientDto.Id,
				CompanyName = clientDto.CompanyName,
				IsDeleted = clientDto.IsDeleted,
				IsPrivateAccount = clientDto.IsPrivateAccount,
				NipNumber = clientDto.NipNumber,
				FirstName = clientDto.FirstName,
				LastName = clientDto.LastName,
				DateOfBirth = clientDto.DateOfBirth,
				Email = clientDto.Email,
				PhoneNumber = clientDto.PhoneNumber,
				DriverLicenseNumber = clientDto.DriverLicenseNumber,
				Notes = clientDto.Notes,
				Address = clientDto.Address
			};
		}
	}
}
