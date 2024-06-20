namespace DriveEase.Infrastructure.Persistance.Configurations
{
	public class ClientConfiguration : IEntityTypeConfiguration<Client>
	{
		public void Configure(EntityTypeBuilder<Client> builder)
		{
			builder.ToTable("Clients");

			builder.Property(e => e.NipNumber).HasMaxLength(15);
			builder.Property(e => e.FirstName).IsRequired().HasMaxLength(50);
			builder.Property(e => e.LastName).IsRequired().HasMaxLength(50);
			builder.Property(e => e.DateOfBirth).IsRequired();
			builder.Property(e => e.Email).IsRequired().HasMaxLength(50);
			builder.Property(e => e.PhoneNumber).IsRequired().HasMaxLength(15);
			builder.Property(e => e.DriverLicenseNumber).IsRequired().HasMaxLength(15);
			builder.Property(e => e.Notes).HasMaxLength(255);
			builder.Property(e => e.NipNumber).HasMaxLength(10);
			builder.Property(e => e.CompanyName).HasMaxLength(50);

			builder.HasOne(e => e.AppUser)
				.WithMany(e => e.Clients)
				.HasForeignKey(e => e.UserId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.HasOne(e => e.Address)
				.WithOne(e => e.Client)
				.HasForeignKey<Client>(e => e.AddressId)
				.OnDelete(DeleteBehavior.Cascade);

			builder.HasIndex(e => e.DriverLicenseNumber).IsUnique();
		}
	}
}
