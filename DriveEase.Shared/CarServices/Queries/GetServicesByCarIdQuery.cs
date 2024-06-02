using DriveEase.Shared.CarServices.Dtos;
using MediatR;

namespace DriveEase.Shared.CarServices.Queries
{
	public class GetServicesByCarIdQuery : IRequest<IEnumerable<ServiceHistoryDto>>
	{
		public int CarId { get; set; }
	}
}
