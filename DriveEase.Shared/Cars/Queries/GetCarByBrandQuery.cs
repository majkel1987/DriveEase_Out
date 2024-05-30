using DriveEase.Application.Cars.Queries;
using MediatR;

namespace DriveEase.Shared.Cars.Queries
{
	public class GetCarByBrandQuery : IRequest<IEnumerable<CarDto>>
	{
		public string Brand { get; set; }
	}
}
