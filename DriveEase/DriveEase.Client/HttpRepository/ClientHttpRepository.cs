using DriveEase.Client.HttpRepository.Interfaces;
using DriveEase.Shared.Clients.Dtos;
using System.Net.Http.Json;

namespace DriveEase.Client.HttpRepository
{
    public class ClientHttpRepository : IClientHttpRepository
    {
        private readonly HttpClient _httpClient;

        public ClientHttpRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ClientDto> CreateClient(CreateClientDto createClientDto)
        {
            var response = await _httpClient.PostAsJsonAsync("Client/CreateClient", createClientDto);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<ClientDto>();
            }
            else
            {
                return null;
            }
        }

        public async Task<ClientDto> CreateClientWithAddress(CreateClientDto createClientDto)
        {
            var response = await _httpClient.PostAsJsonAsync("Client/CreateClientWithAddress", createClientDto);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<ClientDto>();
            }
            else
            {
                return null;
            }
        }
        public async Task DeleteClient(int id)
        {
            await _httpClient.DeleteAsync($"Client/{id}");
        }

        public async Task<ClientDto> GetClient(int id)
        {
            return await _httpClient.GetFromJsonAsync<ClientDto>($"Client/{id}");
        }

        public async Task<IEnumerable<ClientDto>> GetClients()
        {

            return await _httpClient.GetFromJsonAsync<IEnumerable<ClientDto>>("Client");

        }

        public async Task<ClientDto> GetClientWithAddress(int id)
        {
            return await _httpClient.GetFromJsonAsync<ClientDto>($"Client/address/{id}");
        }

        public async Task<ClientDto> UpdateClient(int id, UpdateClientDto updateClientDto)
        {
            var response = await _httpClient.PutAsJsonAsync($"Client/{id}", updateClientDto);


            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<ClientDto>();
            }
            else
            {
                return null;

            }
        }
    }
}

