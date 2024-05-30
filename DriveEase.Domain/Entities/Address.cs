namespace DriveEase.Domain.Entities
{
	public class Address
	{
		public int Id { get; set; }
		public string Street { get; set; }
		public string City { get; set; }
		public string PostalCode { get; set; }
		public string Country { get; set; }

		public string UserId { get; set; }
		public AppUser AppUser { get; set; }
		public int ClientId { get; set; }
		public Client Client { get; set; }
	}
}
