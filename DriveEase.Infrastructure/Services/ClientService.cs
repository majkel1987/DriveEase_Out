namespace DriveEase.Infrastructure.Services
{
	public class ClientService : IClientService
	{
		private readonly IApplicationDbContext _context;

		public ClientService(IApplicationDbContext context)
		{
			_context = context;
		}
		public async Task<Client> CreateClientAsync(Client client)
		{
			_context.Clients.Add(client);
			await _context.SaveChangesAsync();
			return client;
		}

		public async Task<Client> CreateClientWithAddress(Client client)
		{
			var transaction = await _context.BeginTransactionAsync();

			try
			{
				var addressToCreate = client.Address.Adapt<Address>();

				_context.Addresses.Add(addressToCreate);
				await _context.SaveChangesAsync();

				client.AddressId = addressToCreate.Id;
				client.Address = addressToCreate;

				_context.Clients.Add(client);
				await _context.SaveChangesAsync();

				await _context.CommitTransactionAsync(transaction);

				return client;
			}
			catch
			{
				await _context.RollbackTransactionAsync(transaction);
				throw;
			}
		}

		public async Task<bool> DeleteClientAsync(int id)
		{
			var clientToDelete = await GetClientByIdAsync(id);

			if (clientToDelete == null)
				return false;

			clientToDelete.IsDeleted = true;
			await _context.SaveChangesAsync();
			return true;
		}

		public async Task<Client> GetClientByIdAsync(int id)
		{
			return await _context.Clients.FirstOrDefaultAsync(c => c.Id == id);
		}

		public async Task<IEnumerable<Client>> GetClientsAsync()
		{
			return await _context.Clients.ToListAsync();

		}

		public async Task<Client> GetClientWithAddress(int id)
		{
			return await _context.Clients
				.Include(c => c.Address)
				.FirstOrDefaultAsync(c => c.Id == id);
		}

		public async Task<Client> UpdateClientAsync(int id, Client client)
		{
			var clientToUpdate = await _context.Clients.FirstOrDefaultAsync(x => x.Id == id);

			if (clientToUpdate == null)
				return null;

			clientToUpdate.FirstName = client.FirstName;
			clientToUpdate.LastName = client.LastName;
			clientToUpdate.DateOfBirth = client.DateOfBirth;
			clientToUpdate.Email = client.Email;
			clientToUpdate.PhoneNumber = client.PhoneNumber;
			clientToUpdate.DriverLicenseNumber = client.DriverLicenseNumber;
			clientToUpdate.Notes = client.Notes;
			clientToUpdate.IsPrivateAccount = client.IsPrivateAccount;
			clientToUpdate.NipNumber = client.NipNumber;

			await _context.SaveChangesAsync();
			return clientToUpdate;
		}
	}
}
