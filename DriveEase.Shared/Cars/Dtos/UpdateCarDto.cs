using DriveEase.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace DriveEase.Shared.Cars.Dtos
{
	public class UpdateCarDto
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Pole 'Numer rejestracyjny' jest wymagane!")]
		[Display(Name = "Numer rejestracyjny")]
		public string LicensePlate { get; set; }

		[Display(Name = "Przebieg")]
		public string Mileage { get; set; }

		[Required(ErrorMessage = "Pole 'Numer polisy ubezpieczeniowej' jest wymagane!")]
		[Display(Name = "Numer polisy ubezpieczeniowej")]
		public string InsurancePolicyNumber { get; set; }

		[Display(Name = "Dostępność")]
		public bool IsAvailable { get; set; }

		[Display(Name = "Data ostatniego przeglądu")]
		public DateTime CarReviewDate { get; set; }

		[Display(Name = "Wyposażenie")]
		public IList<string> Features { get; set; }

		[Display(Name = "Status")]
		public CarStatus Status { get; set; }
	}
}
