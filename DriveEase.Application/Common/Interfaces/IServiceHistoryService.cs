using DriveEase.Domain.Entities;

namespace DriveEase.Application.Common.Interfaces
{
	public interface IServiceHistoryService
	{
		Task<IEnumerable<ServiceHistory>> GetAllServices();
		Task<IEnumerable<ServiceHistory>> GetServicesByCarId(int carId);
		Task<ServiceHistory> GetServiceById(int serviceId);
		Task<ServiceHistory> CreateServiceAsync(ServiceHistory service);
		Task<ServiceHistory> UpdateServiceAsync(ServiceHistory service, int id);
		Task<bool> DeleteService(int serviceId);
	}
}
