
using Microsoft.EntityFrameworkCore.Storage;

namespace DriveEase.Infrastructure.Persistance
{
	public class ApplicationDbContext : IdentityDbContext<AppUser>, IApplicationDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}

		public DbSet<Address> Addresses { get; set; }
		public DbSet<Car> Cars { get; set; }
		public DbSet<Client> Clients { get; set; }
		public DbSet<Employee> Employees { get; set; }
		public DbSet<Notification> Notifications { get; set; }
		public DbSet<Invoice> Invoices { get; set; }
		public DbSet<Rental> Rentals { get; set; }
		public DbSet<Reservation> Reservations { get; set; }
		public DbSet<Review> Reviews { get; set; }
		public DbSet<ServiceHistory> ServiceHistory { get; set; }
		public DbSet<RentalRate> RentalRates { get; set; }

		public async Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken = default)
		{
			return await Database.BeginTransactionAsync(cancellationToken);
		}

		public async Task CommitTransactionAsync(IDbContextTransaction transaction, CancellationToken cancellationToken = default)
		{
			await transaction.CommitAsync(cancellationToken);
		}

		public async Task RollbackTransactionAsync(IDbContextTransaction transaction, CancellationToken cancellationToken = default)
		{
			await transaction.RollbackAsync(cancellationToken);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
			modelBuilder.SeedCars();
			modelBuilder.SeedServiceHistory();
			modelBuilder.SeedClients();
			modelBuilder.SeedRoles();
			modelBuilder.SeedAddresses();

			base.OnModelCreating(modelBuilder);
		}
	}
}
