namespace DriveEase.Infrastructure.Persistance.Extensions
{
	static class ModelBuilderExtensionsClient
	{
		public static void SeedClients(this ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Client>().HasData(
				new Client
				{
					Id = 1,
					AddressId = 1,
					IsPrivateAccount = true,
					FirstName = "John",
					LastName = "Doe",
					Email = "john.doe@icloud.com",
					PhoneNumber = "123456789",
					DriverLicenseNumber = "123456789",
					Notes = "Regular customer",
					IsDeleted = false,
				},
				new Client
				{
					Id = 2,
					AddressId = 2,
					IsPrivateAccount = false,
					NipNumber = 1234567890,
					CompanyName = "Doe & Partners",
					FirstName = "Jane",
					LastName = "Doe",
					Email = "jane.doe@onet.pl",
					PhoneNumber = "987654321",
					DriverLicenseNumber = "987654321",
					Notes = "Business customer",
					IsDeleted = false,
				},
				new Client
				{
					Id = 3,
					AddressId = 3,
					IsPrivateAccount = true,
					FirstName = "Alice",
					LastName = "Smith",
					Email = "a.smith@wp.pl",
					PhoneNumber = "222565321",
					DriverLicenseNumber = "ABD2241723",
					Notes = "New regular customer",
					IsDeleted = false,
				},
				new Client
				{
					Id = 4,
					AddressId = 4,
					IsPrivateAccount = false,
					NipNumber = 9876543210,
					CompanyName = "Smith & Co.",
					FirstName = "Bob",
					LastName = "Vance",
					Email = "vance.b@gmail.com",
					PhoneNumber = "553268145",
					DriverLicenseNumber = "VAN123456",
					Notes = "Business customer",
					IsDeleted = false,
				}
				);
		}

	}
}
