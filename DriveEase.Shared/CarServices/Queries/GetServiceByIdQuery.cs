using DriveEase.Shared.CarServices.Dtos;
using MediatR;

namespace DriveEase.Shared.CarServices.Queries
{
	public class GetServiceByIdQuery : IRequest<ServiceHistoryDto>
	{
		public int Id { get; set; }
	}
}
