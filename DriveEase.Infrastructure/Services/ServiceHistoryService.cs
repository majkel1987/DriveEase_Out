namespace DriveEase.Infrastructure.Services
{
	public class ServiceHistoryService : IServiceHistoryService
	{
		private readonly IApplicationDbContext _context;

		public ServiceHistoryService(IApplicationDbContext context)
		{
			_context = context;
		}
		public async Task<IEnumerable<ServiceHistory>> GetAllServices()
		{
			return await _context.ServiceHistory.ToListAsync();
		}
	}
}
