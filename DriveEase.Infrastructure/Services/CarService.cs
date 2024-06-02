namespace DriveEase.Infrastructure.Services
{
	public class CarService : ICarService
	{
		private readonly IApplicationDbContext _context;

		public CarService(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<Car> CreateCarAsync(Car car)
		{
			_context.Cars.Add(car);
			await _context.SaveChangesAsync();
			return car;
		}

		public async Task<bool> DeleteCarAsync(int id)
		{
			var carToDelete = await GetCarByIdAsync(id);

			if (carToDelete == null)
				return false;

			carToDelete.IsDeleted = true;
			await _context.SaveChangesAsync();

			return true;
		}

		public async Task<IEnumerable<Car>> GetCarByBrandAsync(string brand)
		{
			return await _context.Cars.Where(c => c.Brand == brand).ToListAsync();
		}

		public async Task<Car> GetCarByIdAsync(int id)
		{
			return await _context.Cars.FirstOrDefaultAsync(c => c.Id == id);
		}

		public async Task<IEnumerable<Car>> GetCarsAsync()
		{
			return await _context.Cars.ToListAsync();
		}

		public async Task<Car> GetCarWithServiceHistoryById(int id)
		{
			return await _context.Cars
				.Include(c => c.ServiceHistory)
				.FirstOrDefaultAsync(c => c.Id == id);
		}

		public async Task<Car> UpdateCarAsync(int id, Car car)
		{
			var carToUpdate = await _context.Cars.FirstOrDefaultAsync(c => c.Id == id);

			if (carToUpdate == null)
				return null;

			carToUpdate.LicensePlate = car.LicensePlate;
			carToUpdate.Mileage = car.Mileage;
			carToUpdate.InsurancePolicyNumber = car.InsurancePolicyNumber;
			carToUpdate.IsAvailable = car.IsAvailable;
			carToUpdate.CarReviewDate = car.CarReviewDate;
			carToUpdate.Features = car.Features;
			carToUpdate.Status = car.Status;

			await _context.SaveChangesAsync();
			return carToUpdate;
		}
	}
}
