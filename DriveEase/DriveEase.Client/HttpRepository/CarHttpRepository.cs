using DriveEase.Application.Cars.Queries;
using DriveEase.Client.HttpRepository.Interfaces;
using DriveEase.Shared.Cars.Dtos;
using System.Net.Http.Json;

namespace DriveEase.Client.HttpRepository
{
	public class CarHttpRepository : ICarHttpRepository
	{
		private readonly HttpClient _httpClient;

		public CarHttpRepository(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public async Task<CarDto> CreateCar(CreateCarDto createCarDto)
		{
			var response = await _httpClient.PostAsJsonAsync("Car", createCarDto);

			if (response.IsSuccessStatusCode)
				return await response.Content.ReadFromJsonAsync<CarDto>();
			else
				return null;
		}

		public async Task DeleteCar(int id)
		{
			await _httpClient.DeleteAsync($"Car/{id}");
		}

		public async Task<CarDto> EditCar(int id, UpdateCarDto updateCarDto)
		{
			var response = await _httpClient.PutAsJsonAsync($"Car/{id}", updateCarDto);

			if (response.IsSuccessStatusCode)
				return await response.Content.ReadFromJsonAsync<CarDto>();
			else
				return null;
		}

		public async Task<CarDto> GetCarById(int id)
		{
			return await _httpClient.GetFromJsonAsync<CarDto>($"Car/{id}");
		}

		public async Task<IEnumerable<CarDto>> GetCars()
		{
			return await _httpClient.GetFromJsonAsync<IEnumerable<CarDto>>("Car");
		}

		public async Task<CarDto> GetCarWithServiceHistory(int id)
		{
			return await _httpClient.GetFromJsonAsync<CarDto>($"Car/service-history/{id}");
		}
	}
}
