namespace DriveEase.Infrastructure.Persistance.Configurations
{
	public class AddressConfiguration : IEntityTypeConfiguration<Address>
	{
		public void Configure(EntityTypeBuilder<Address> builder)
		{
			builder.ToTable("Addresses");

			builder.Property(e => e.Street).IsRequired().HasMaxLength(100);
			builder.Property(e => e.City).IsRequired().HasMaxLength(50);
			builder.Property(e => e.PostalCode).IsRequired().HasMaxLength(6);
			builder.Property(e => e.Country).IsRequired().HasMaxLength(50);
		}
	}
}
