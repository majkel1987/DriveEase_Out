using MediatR;

namespace DriveEase.Application.Cars.Queries
{
	public class GetCarsQuery : IRequest<IEnumerable<CarDto>>
	{
	}
}
