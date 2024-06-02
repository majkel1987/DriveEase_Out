using DriveEase.Shared.CarServices.Dtos;

namespace DriveEase.Client.HttpRepository.Interfaces
{
	public interface IServiceHttpRepository
	{
		Task<IEnumerable<ServiceHistoryDto>> GetAllServices();
		Task<IEnumerable<ServiceHistoryDto>> GetServicesByCarId(int carId);
	}
}
