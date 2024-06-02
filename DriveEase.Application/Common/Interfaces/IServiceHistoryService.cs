using DriveEase.Domain.Entities;

namespace DriveEase.Application.Common.Interfaces
{
	public interface IServiceHistoryService
	{
		Task<IEnumerable<ServiceHistory>> GetAllServices();
		Task<IEnumerable<ServiceHistory>> GetServicesByCarId(int carId);
	}
}
