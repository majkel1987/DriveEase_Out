using DriveEase.Domain.Entities;

namespace DriveEase.Application.Common.Interfaces
{
	public interface IClientService
	{
		Task<IEnumerable<Client>> GetClientsAsync();
		Task<Client> GetClientByIdAsync(int id);
		Task<Client> GetClientWithAddress(int id);
		Task<Client> CreateClientAsync(Client client);
		Task<Client> CreateClientWithAddress(Client client);
		Task<Client> UpdateClientAsync(int id, Client client);
		Task<bool> DeleteClientAsync(int id);
	}
}
