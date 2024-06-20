namespace DriveEase.Infrastructure.Persistance.Extensions
{
	static class ModelBuilderExtensionsAddress
	{
		public static void SeedAddresses(this ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Address>().HasData(
				new Address
				{
					Id = 1,
					Street = "Main Street 1",
					City = "New York",
					PostalCode = "10-001",
					Country = "USA"
				},
				new Address
				{
					Id = 2,
					Street = "Broadway 2",
					City = "Berlin",
					PostalCode = "90-001",
					Country = "Germany"
				},
				new Address
				{
					Id = 3,
					Street = "Sunset Boulevard 3",
					City = "Los Angeles",
					PostalCode = "90-001",
					Country = "USA"
				},
				new Address
				{
					Id = 4,
					Street = "Hollywood Boulevard 4",
					City = "Warsaw",
					PostalCode = "90-001",
					Country = "Poland"
				}
				);
		}

	}
}
