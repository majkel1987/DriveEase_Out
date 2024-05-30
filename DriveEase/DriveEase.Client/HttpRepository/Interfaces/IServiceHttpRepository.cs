using DriveEase.Shared.CarServices.Dtos;

namespace DriveEase.Client.HttpRepository.Interfaces
{
	public interface IServiceHttpRepository
	{
		Task<IEnumerable<ServiceHistoryDto>> GetAllServices();
	}
}
