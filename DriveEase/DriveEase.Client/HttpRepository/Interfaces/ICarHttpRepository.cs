using DriveEase.Application.Cars.Queries;
using DriveEase.Shared.Cars.Dtos;

namespace DriveEase.Client.HttpRepository.Interfaces
{
	public interface ICarHttpRepository
	{
		Task<IEnumerable<CarDto>> GetCars();
		Task<CarDto> GetCarById(int id);
		Task<CarDto> CreateCar(CreateCarDto createCarDto);
		Task<CarDto> EditCar(int id, UpdateCarDto updateCarDto);
		Task DeleteCar(int id);
	}
}
