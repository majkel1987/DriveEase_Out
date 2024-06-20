using DriveEase.Shared.Addresses.Dtos;
using DriveEase.Shared.Clients.Dtos;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace DriveEase.Shared.Clients.Commands
{
	public class CreateClientWithAddressCommand : IRequest<CreateClientDto>
	{
		public bool IsPrivateAccount { get; set; }
		public string CompanyName { get; set; }
		public long NipNumber { get; set; }
		[Required(ErrorMessage = "Field 'First Name' is required")]
		public string FirstName { get; set; }

		[Required(ErrorMessage = "Field 'Last Name' is required")]
		public string LastName { get; set; }

		[Required(ErrorMessage = "Field 'Date of Birth' is required")]
		public DateTime DateOfBirth { get; set; }

		[Required(ErrorMessage = "Field 'Email' is required")]
		[EmailAddress(ErrorMessage = "Field 'Email' is not a valid email address")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Field 'Phone Number' is required")]
		public string PhoneNumber { get; set; }

		[Required(ErrorMessage = "Field 'Driver License Number' is required")]
		public string DriverLicenseNumber { get; set; }
		public string Notes { get; set; }
		public AddressDto Address { get; set; }
	}
}
