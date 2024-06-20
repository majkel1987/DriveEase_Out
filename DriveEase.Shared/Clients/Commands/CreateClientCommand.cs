using DriveEase.Shared.Clients.Dtos;
using MediatR;

namespace DriveEase.Shared.Clients.Commands
{
	public class CreateClientCommand : IRequest<CreateClientDto>
	{
		public string CompanyName { get; set; }
		public bool IsDeleted { get; set; } = false;
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
		public string DriverLicenseNumber { get; set; }
		public string Notes { get; set; }
		public bool IsPrivateAccount { get; set; }
		public long NipNumber { get; set; }
	}
}
