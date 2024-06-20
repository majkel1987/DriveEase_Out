using System.ComponentModel.DataAnnotations;

namespace DriveEase.Shared.Addresses.Dtos
{
	public class AddressDto
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Field 'Street' is required")]
		public string Street { get; set; }

		[Required(ErrorMessage = "Field 'City' is required")]
		public string City { get; set; }

		[Required(ErrorMessage = "Field 'Postal Code' is required")]
		public string PostalCode { get; set; }

		[Required(ErrorMessage = "Field 'Country' is required")]
		public string Country { get; set; }

	}
}
