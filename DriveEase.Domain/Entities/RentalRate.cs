namespace DriveEase.Domain.Entities
{
	public class RentalRate
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Rate { get; set; }
		public decimal Deposit { get; set; }
		public decimal LateFee { get; set; }
		public decimal CleaningFee { get; set; }
		public decimal FuelFee { get; set; }
		public decimal DiscountRate { get; set; }
		public decimal Total { get; set; }
		public DateTime ValidFrom { get; set; }
		public DateTime ValidUntil { get; set; }
		public int CarId { get; set; }
		public Car Car { get; set; }
	}
}
