using DriveEase.Shared.Clients.Dtos;

namespace DriveEase.Client.HttpRepository.Interfaces
{
	public interface IClientHttpRepository
	{
		Task<IEnumerable<ClientDto>> GetClients();
		Task<ClientDto> GetClient(int id);
		Task<ClientDto> GetClientWithAddress(int id);
		Task<ClientDto> CreateClient(CreateClientDto createClientDto);
		Task<ClientDto> CreateClientWithAddress(CreateClientDto createClientDto);
		Task<ClientDto> UpdateClient(int id, UpdateClientDto updateClientDto);
		Task DeleteClient(int id);
	}
}
