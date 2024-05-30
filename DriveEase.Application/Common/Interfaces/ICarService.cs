using DriveEase.Domain.Entities;

namespace DriveEase.Application.Common.Interfaces
{
	public interface ICarService
	{
		Task<IEnumerable<Car>> GetCarsAsync();
		Task<Car> GetCarByIdAsync(int id);
		Task<IEnumerable<Car>> GetCarByBrandAsync(string brand);
		Task<Car> GetCarWithServiceHistoryById(int id);
		Task<Car> CreateCarAsync(Car car);
		Task<Car> UpdateCarAsync(int id, Car car);
		Task<bool> DeleteCarAsync(int id);
	}
}
