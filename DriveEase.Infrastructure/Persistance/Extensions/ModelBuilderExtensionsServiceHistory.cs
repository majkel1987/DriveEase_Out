using DriveEase.Domain.Enums;

namespace DriveEase.Infrastructure.Persistance.Extensions
{
	static class ModelBuilderExtensionsServiceHistory
	{
		public static void SeedServiceHistory(this ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<ServiceHistory>().HasData(
				new ServiceHistory
				{
					Id = 1,
					CarId = 1,
					ServiceDate = new DateTime(2023, 3, 12),
					ServiceEndDate = new DateTime(2023, 3, 15),
					ServiceType = "Oil Change",
					Description = "Change oil and filter",
					Cost = 150,
					ServiceProvider = "Toyo",
					Notes = "Car is running smoothly",
					IsFinished = true,
					Status = ServiceStatus.Completed
				},
				new ServiceHistory
				{
					Id = 2,
					CarId = 2,
					ServiceDate = new DateTime(2023, 12, 11),
					ServiceEndDate = new DateTime(2023, 12, 15),
					ServiceType = "Tire Rotation",
					Description = "Rotate tires",
					Cost = 200,
					ServiceProvider = "Mech-1",
					Notes = "Tires are wearing evenly",
					IsFinished = true,
					Status = ServiceStatus.Completed
				},
				new ServiceHistory
				{
					Id = 3,
					CarId = 3,
					ServiceDate = new DateTime(2022, 5, 14),
					ServiceEndDate = new DateTime(2022, 6, 23),
					ServiceType = "Brake Inspection",
					Description = "Inspect brakes",
					Cost = 1000,
					ServiceProvider = "Jiffy Lube",
					Notes = "Brakes are in bad condition",
					IsFinished = false,
					Status = ServiceStatus.InProgress
				},
				new ServiceHistory
				{
					Id = 4,
					CarId = 3,
					ServiceDate = new DateTime(2022, 8, 21),
					ServiceType = "Air conditioninig service",
					Description = "Recharge AC",
					Cost = 300,
					ServiceProvider = "Cooling Experts",
					Notes = "AC is working properly",
					IsFinished = false,
					Status = ServiceStatus.Planned
				},
				new ServiceHistory
				{
					Id = 5,
					CarId = 2,
					ServiceDate = new DateTime(2024, 2, 16),
					ServiceEndDate = new DateTime(2024, 2, 18),
					ServiceType = "Engine Inspection",
					Description = "Inspect engine",
					Cost = 500,
					ServiceProvider = "Auto Care",
					Notes = "Engine is in good condition",
					IsFinished = true,
					Status = ServiceStatus.Planned
				},
				new ServiceHistory
				{
					Id = 6,
					CarId = 2,
					ServiceDate = new DateTime(2024, 4, 16),
					ServiceEndDate = new DateTime(2024, 4, 18),
					ServiceType = "Inspection",
					Description = "Inspect vehicle",
					Cost = 1200,
					ServiceProvider = "Auto Care",
					Notes = "Service cancelled",
					IsFinished = true,
					Status = ServiceStatus.Cancelled
				},
				new ServiceHistory
				{
					Id = 7,
					CarId = 2,
					ServiceDate = new DateTime(2024, 5, 16),
					ServiceEndDate = new DateTime(2024, 5, 18),
					ServiceType = "Inspection",
					Description = "Inspect vehicle",
					Cost = 1200,
					ServiceProvider = "Auto Care",
					Notes = "Service cancelled",
					IsFinished = true,
					Status = ServiceStatus.InProgress
				}
				);
		}
	}
}
