using Microsoft.AspNetCore.Identity;

namespace DriveEase.Domain.Entities
{
	public class AppUser : IdentityUser
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime DateOfBirth { get; set; }
		public bool IsDeleted { get; set; }
		public int AddressId { get; set; }
		public Address Address { get; set; }
		public ICollection<Employee> Employees { get; set; }
		public ICollection<Client> Clients { get; set; }
	}

}
