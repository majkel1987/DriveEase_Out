using DriveEase.Application.Cars.Queries;
using DriveEase.Client.HttpRepository.Interfaces;
using System.Net.Http.Json;

namespace DriveEase.Client.HttpRepository
{
	public class CarRepository : ICarRepository
	{
		private readonly HttpClient _client;

		public CarRepository(HttpClient client)
		{
			_client = client;
		}

		public async Task<List<CarDto>> GetCars()
		{
			var response = await _client.GetAsync("api/cars");

			if (response.IsSuccessStatusCode)
			{
				var cars = await response.Content.ReadFromJsonAsync<List<CarDto>>();
				return cars;
			}

			return null;
		}

	}
}
