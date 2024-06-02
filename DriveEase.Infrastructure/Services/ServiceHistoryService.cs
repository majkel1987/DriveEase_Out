namespace DriveEase.Infrastructure.Services
{
	public class ServiceHistoryService : IServiceHistoryService
	{
		private readonly IApplicationDbContext _context;

		public ServiceHistoryService(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<ServiceHistory> CreateServiceAsync(ServiceHistory service)
		{
			_context.ServiceHistory.Add(service);
			await _context.SaveChangesAsync();
			return service;
		}

		public async Task<bool> DeleteService(int serviceId)
		{
			var serviceToRemove = _context.ServiceHistory.FirstOrDefault(x => x.Id == serviceId);

			if (serviceToRemove == null)
			{
				return false;
			}

			serviceToRemove.IsDeleted = true;
			await _context.SaveChangesAsync();
			return true;
		}

		public async Task<IEnumerable<ServiceHistory>> GetAllServices()
		{
			return await _context.ServiceHistory.ToListAsync();
		}

		public async Task<IEnumerable<ServiceHistory>> GetServicesByCarId(int carId)
		{
			return await _context.ServiceHistory
				.Where(x => x.CarId == carId)
				.ToListAsync();
		}

		public async Task<ServiceHistory> UpdateServiceAsync(ServiceHistory service, int id)
		{
			var serviceToUpdate = _context.ServiceHistory
				.FirstOrDefault(x => x.Id == id);

			if (serviceToUpdate == null)
			{
				return null;
			}

			serviceToUpdate.ServiceDate = service.ServiceDate;
			serviceToUpdate.ServiceEndDate = service.ServiceEndDate;
			serviceToUpdate.ServiceType = service.ServiceType;
			serviceToUpdate.Description = service.Description;
			serviceToUpdate.Cost = service.Cost;
			serviceToUpdate.ServiceProvider = service.ServiceProvider;
			serviceToUpdate.Notes = service.Notes;
			serviceToUpdate.IsFinished = service.IsFinished;
			serviceToUpdate.Status = service.Status;

			await _context.SaveChangesAsync();
			return serviceToUpdate;
		}
	}
}
