namespace DriveEase.Domain.Entities
{
	public class Rental
	{
		public int Id { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public decimal TotalPrice { get; set; }
		public int CarId { get; set; }
		public Car Car { get; set; }
        public int InvoiceId { get; set; }
		public Invoice Invoice { get; set; }
        public int ClientId { get; set; }
		public Client Client { get; set; }
		public ICollection<Review> Reviews { get; set; } = new HashSet<Review>();
	}
}
