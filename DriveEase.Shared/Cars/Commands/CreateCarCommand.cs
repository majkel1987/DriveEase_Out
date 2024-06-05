using DriveEase.Domain.Enums;
using DriveEase.Shared.Cars.Dtos;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace DriveEase.Shared.Cars.Commands
{
	public class CreateCarCommand : IRequest<CreateCarDto>
	{
		[Required(ErrorMessage = "Pole 'Marka' jest wymagane!")]
		[Display(Name = "Marka")]
		public string Brand { get; set; }

		[Required(ErrorMessage = "Pole 'Model' jest wymagane!")]
		[Display(Name = "Model")]
		public string Model { get; set; }

		[Required(ErrorMessage = "Pole 'Rok produkcji' jest wymagane!")]
		[Display(Name = "Rok produkcji")]
		public int Year { get; set; }

		[Required(ErrorMessage = "Pole 'Numer rejestracyjny' jest wymagane!")]
		[Display(Name = "Numer rejestracyjny")]
		public string LicensePlate { get; set; }

		[Required(ErrorMessage = "Pole 'Numer VIN' jest wymagane!")]
		[Display(Name = "Numer VIN")]
		public string VinNumber { get; set; }

		[Display(Name = "Kolor")]
		public string Color { get; set; }

		[Display(Name = "Przebieg")]
		public string Mileage { get; set; }

		[Required(ErrorMessage = "Pole 'Rodzaj paliwa' jest wymagane!")]
		[Display(Name = "Rodzaj paliwa")]
		public FuelTypeEngines FuelType { get; set; }

		[Display(Name = "Skrzynia biegów")]
		public string Transmission { get; set; }

		[Required(ErrorMessage = "Pole 'Silnik' jest wymagane!")]
		[Display(Name = "Silnik")]
		public string Engine { get; set; }

		[Required(ErrorMessage = "Pole 'Numer polisy ubezpieczeniowej' jest wymagane!")]
		[Display(Name = "Numer polisy ubezpieczeniowej")]
		public string InsurancePolicyNumber { get; set; }

		[Display(Name = "Dostępność")]
		public bool IsAvailable { get; set; }

		[Display(Name = "Moc")]
		public string Power { get; set; }

		[Display(Name = "Data ostatniego przeglądu")]
		public DateTime CarReviewDate { get; set; }

		[Display(Name = "Data dodania")]
		public DateTime AddDate { get; set; } = DateTime.Now;

		[Display(Name = "Wyposażenie")]
		public IList<string> Features { get; set; }

		[Display(Name = "Status")]
		public CarStatus Status { get; set; }
	}
}

