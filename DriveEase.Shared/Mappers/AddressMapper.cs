using DriveEase.Domain.Entities;
using DriveEase.Shared.Addresses.Dtos;

namespace DriveEase.Shared.Mappers
{
	public static class AddressMapper
	{
		public static Address ToAddressEntity(this AddressDto dto)
		{
			if (dto == null)
			{
				return null;
			}

			return new Address
			{
				Id = dto.Id,
				Street = dto.Street,
				City = dto.City,
				PostalCode = dto.PostalCode,
				Country = dto.Country
			};
		}
		public static AddressDto ToAddressDto(this Address address)
		{
			if (address == null)
			{
				return null;
			}

			return new AddressDto
			{
				Id = address.Id,
				Street = address.Street,
				City = address.City,
				PostalCode = address.PostalCode,
				Country = address.Country
			};
		}
	}
}
