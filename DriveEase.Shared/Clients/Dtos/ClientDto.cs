namespace DriveEase.Shared.Clients.Dtos
{
	public class ClientDto
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
		public string DriverLicenseNumber { get; set; }
		public string Notes { get; set; }
		public bool IsPrivateAccount { get; set; }
		public string NipNumber { get; set; }
	}
}
