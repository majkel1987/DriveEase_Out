using DriveEase.Client.HttpRepository.Interfaces;
using DriveEase.Shared.CarServices.Dtos;
using System.Net.Http.Json;

namespace DriveEase.Client.HttpRepository
{
	public class ServiceHttpRepository : IServiceHttpRepository
	{
		private readonly HttpClient _httpClient;

		public ServiceHttpRepository(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}
		public async Task<IEnumerable<ServiceHistoryDto>> GetAllServices()
		{
			return await _httpClient.GetFromJsonAsync<IEnumerable<ServiceHistoryDto>>("Service");
		}

		public async Task<IEnumerable<ServiceHistoryDto>> GetServicesByCarId(int carId)
		{
			return await _httpClient.GetFromJsonAsync<IEnumerable<ServiceHistoryDto>>($"Service/car/{carId}");
		}
	}
}
