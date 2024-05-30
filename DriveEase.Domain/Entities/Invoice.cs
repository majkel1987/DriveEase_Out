namespace DriveEase.Domain.Entities
{
	public class Invoice
	{
		public int Id { get; set; }
		
		public decimal Value { get; set; }
        public int Year { get; set; }
		public int Month { get; set; }
        public string MethodOfPayment { get; set; }
        public DateTime CreateDate { get; set; }
        public int RentalId { get; set; }
		public Rental Rental { get; set; }
		public int ClientId { get; set; }
		public Client Client { get; set; }
	}
}
