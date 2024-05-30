using DriveEase.Application.Cars.Queries;
using MediatR;

namespace DriveEase.Shared.Cars.Queries
{
    public class GetCarWithServiceHistoryQuery : IRequest<CarDto>
    {
        public int Id { get; set; }
    }
}
