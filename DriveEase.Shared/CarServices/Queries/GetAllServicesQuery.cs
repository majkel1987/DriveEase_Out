using DriveEase.Shared.CarServices.Dtos;
using MediatR;

namespace DriveEase.Shared.CarServices.Queries
{
    public class GetAllServicesQuery : IRequest<IEnumerable<ServiceHistoryDto>>
    {
    }
}
