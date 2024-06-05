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

		public async Task<ServiceHistoryDto> CreateService(CreateServiceDto createServiceDto)
		{
			var response = await _httpClient.PostAsJsonAsync("Service", createServiceDto);

			if (response.IsSuccessStatusCode)
				return await response.Content.ReadFromJsonAsync<ServiceHistoryDto>();
			else
				return null;
		}

		public async Task DeleteService(int serviceId)
		{
			await _httpClient.DeleteAsync($"Service/{serviceId}");
		}

		public async Task<ServiceHistoryDto> EditService(int serviceId, UpdateServiceDto updateServiceDto)
		{
			var response = await _httpClient.PutAsJsonAsync($"Service/{serviceId}", updateServiceDto);

			if (response.IsSuccessStatusCode)
				return await response.Content.ReadFromJsonAsync<ServiceHistoryDto>();
			else
				return null;
		}

		public async Task<IEnumerable<ServiceHistoryDto>> GetAllServices()
		{
			return await _httpClient.GetFromJsonAsync<IEnumerable<ServiceHistoryDto>>("Service");
		}

		public async Task<ServiceHistoryDto> GetServiceById(int serviceId)
		{
			return await _httpClient.GetFromJsonAsync<ServiceHistoryDto>($"Service/{serviceId}");
		}

		public async Task<IEnumerable<ServiceHistoryDto>> GetServicesByCarId(int carId)
		{
			return await _httpClient.GetFromJsonAsync<IEnumerable<ServiceHistoryDto>>($"Service/car/{carId}");
		}
	}
}
