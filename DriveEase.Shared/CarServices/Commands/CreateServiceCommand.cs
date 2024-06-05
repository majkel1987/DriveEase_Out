using DriveEase.Domain.Enums;
using DriveEase.Shared.CarServices.Dtos;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace DriveEase.Shared.CarServices.Commands
{
	public class CreateServiceCommand : IRequest<CreateServiceDto>
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "Field 'Service date' is required")]
		public DateTime ServiceDate { get; set; }

		public DateTime? ServiceEndDate { get; set; }

		[Required(ErrorMessage = "Field 'Service type' is required")]
		public string ServiceType { get; set; }

		[Required(ErrorMessage = "Field 'Description' is required")]
		public string Description { get; set; }

		[Required(ErrorMessage = "Cost' is required")]
		public decimal Cost { get; set; }

		[Required(ErrorMessage = "Field 'Service provider' is required")]
		public string ServiceProvider { get; set; }

		public string Notes { get; set; }

		[Required(ErrorMessage = "Field 'Status' is required")]
		public ServiceStatus Status { get; set; }

		[Required]
		public int CarId { get; set; }
	}
}
