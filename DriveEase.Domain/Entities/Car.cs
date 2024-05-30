using DriveEase.Domain.Enums;

namespace DriveEase.Domain.Entities
{
	public class Car
	{
		public int Id { get; set; }
		public string Brand { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }
		public string LicensePlate { get; set; }
		public string LocationGPS { get; set; }
		public string ImageURL { get; set; }
		public string LogoURL { get; set; }
		public string VinNumber { get; set; }
		public string Color { get; set; }
		public string Mileage { get; set; }
		public FuelTypeEngines FuelType { get; set; }
		public string Transmission { get; set; }
		public string Engine { get; set; }
		public string InsurancePolicyNumber { get; set; }
		public bool IsAvailable { get; set; }
		public bool IsDeleted { get; set; } = false;
		public string Power { get; set; }
		public DateTime CarReviewDate { get; set; }
		public DateTime AddDate { get; set; }
		public IList<string> Features { get; set; }

		public CarStatus Status { get; set; }
		public ICollection<ServiceHistory> ServiceHistory { get; set; } = new HashSet<ServiceHistory>();
		public ICollection<Rental> Rentals { get; set; } = new HashSet<Rental>();
		public ICollection<Reservation> Reservations { get; set; } = new HashSet<Reservation>();
		public ICollection<RentalRate> RentalRates { get; set; } = new HashSet<RentalRate>();
	}
}
