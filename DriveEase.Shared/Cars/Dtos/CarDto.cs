using DriveEase.Domain.Enums;
using DriveEase.Shared.CarServices.Dtos;

namespace DriveEase.Application.Cars.Queries
{
    public class CarDto
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
		public bool IsDeleted { get; set; }
		public string Power { get; set; }
		public DateTime CarReviewDate { get; set; }
		public DateTime AddDate { get; set; }
		public string Status { get; set; }
		public IList<string> Features { get; set; }
		public IEnumerable<ServiceHistoryDto> ServiceHistory { get; set; }

	}
}
