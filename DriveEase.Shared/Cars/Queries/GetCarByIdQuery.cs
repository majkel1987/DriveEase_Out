using DriveEase.Application.Cars.Queries;
using MediatR;

namespace DriveEase.Shared.Cars.Queries
{
	public class GetCarByIdQuery : IRequest<CarDto>
	{
		public int Id { get; set; }
	}
}
