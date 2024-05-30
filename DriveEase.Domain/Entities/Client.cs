namespace DriveEase.Domain.Entities
{
	public class Client
	{
		public int Id { get; set; }
		public bool IsPrivateAccount { get; set; }
		public long NipNumber { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
		public string DriverLicenseNumber { get; set; }
		public string Notes { get; set; }
		public string UserId { get; set; }
		public AppUser AppUser { get; set; }
		public string AddressId { get; set; }
		public Address Address { get; set; }
		public ICollection<Rental> Rentals { get; set; } = new HashSet<Rental>();
		public ICollection<Review> Reviews { get; set; } = new HashSet<Review>();
		public ICollection<Invoice> Invoices { get; set; } = new HashSet<Invoice>();
		public ICollection<Notification> Notifications { get; set; } = new HashSet<Notification>();
		public ICollection<Reservation> Reservations { get; set; } = new HashSet<Reservation>();
	}
}
