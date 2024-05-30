using DriveEase.Domain.Enums;

namespace DriveEase.Domain.Entities
{
	public class Employee
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime DayOfEmployment { get; set; }
		public DateTime DayOfDismissal { get; set; }
		public decimal Salary { get; set; }
		public string ImageUrl { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
		public EmployeeStatus Status { get; set; }
		public Position Position { get; set; }
		public string UserId { get; set; }
		public AppUser AppUser { get; set; }

	}
}
