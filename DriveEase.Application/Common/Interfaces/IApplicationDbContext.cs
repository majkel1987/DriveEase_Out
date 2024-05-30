using DriveEase.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DriveEase.Application.Common.Interfaces
{
	public interface IApplicationDbContext : IDisposable
	{
		DbSet<Address> Addresses { get; set; }
		DbSet<Car> Cars { get; set; }
		DbSet<Client> Clients { get; set; }
		DbSet<Employee> Employees { get; set; }
		DbSet<Notification> Notifications { get; set; }
		DbSet<Invoice> Invoices { get; set; }
		DbSet<Rental> Rentals { get; set; }
		DbSet<Reservation> Reservations { get; set; }
		DbSet<Review> Reviews { get; set; }
		DbSet<ServiceHistory> ServiceHistory { get; set; }
		DbSet<RentalRate> RentalRates { get; set; }
		Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
	}
}
