using System.ComponentModel.DataAnnotations;

namespace DriveEase.Shared.Cars.Dtos
{
	public class CreateCarDto
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Pole 'Marka' jest wymagane!")]
		[Display(Name = "Brand")]
		public string Brand { get; set; }

		[Required(ErrorMessage = "Pole 'Model' jest wymagane!")]
		[Display(Name = "Model")]
		public string Model { get; set; }

		[Required(ErrorMessage = "Pole 'Rok produkcji' jest wymagane!")]
		[Display(Name = "Year of production")]
		public int Year { get; set; }

		[Required(ErrorMessage = "Pole 'Numer rejestracyjny' jest wymagane!")]
		[Display(Name = "License plate number")]
		public string LicensePlate { get; set; }

		[Required(ErrorMessage = "Pole 'Numer VIN' jest wymagane!")]
		[Display(Name = "VIN number")]
		public string VinNumber { get; set; }

		[Display(Name = "Color")]
		public string Color { get; set; }

		[Display(Name = "Mileage")]
		public string Mileage { get; set; }

		[Required(ErrorMessage = "Pole 'Rodzaj paliwa' jest wymagane!")]
		[Display(Name = "Fuel type")]
		public string FuelType { get; set; }

		[Display(Name = "Transmission")]
		public string Transmission { get; set; }

		[Required(ErrorMessage = "Pole 'Silnik' jest wymagane!")]
		[Display(Name = "Engine")]
		public string Engine { get; set; }

		[Required(ErrorMessage = "Pole 'Numer polisy ubezpieczeniowej' jest wymagane!")]
		[Display(Name = "Insurance policy number")]
		public string InsurancePolicyNumber { get; set; }

		[Display(Name = "Availability")]
		public bool IsAvailable { get; set; }

		[Display(Name = "Power")]
		public string Power { get; set; }

		[Display(Name = "Car review date")]
		public DateTime CarReviewDate { get; set; }

		[Display(Name = "Add date")]
		public DateTime AddDate { get; set; } = DateTime.Now;

		[Display(Name = "Equipment")]
		public IList<string> Features { get; set; }

		[Display(Name = "Status")]
		public string Status { get; set; }
	}
}
