using DriveEase.Application.Cars.Queries;
namespace DriveEase.Client.HttpRepository.Interfaces
{
	public interface ICarRepository
	{
		Task<List<CarDto>> GetCars();
	}
}
