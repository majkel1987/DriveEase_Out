using DriveEase.Shared.CarServices.Dtos;

namespace DriveEase.Client.HttpRepository.Interfaces
{
	public interface IServiceHttpRepository
	{
		Task<IEnumerable<ServiceHistoryDto>> GetAllServices();
		Task<IEnumerable<ServiceHistoryDto>> GetServicesByCarId(int carId);
		Task<ServiceHistoryDto> GetServiceById(int serviceId);
		Task<ServiceHistoryDto> CreateService(CreateServiceDto createServiceDto);
		Task<ServiceHistoryDto> EditService(int serviceId, UpdateServiceDto updateServiceDto);
		Task DeleteService(int serviceId);
	}
}
