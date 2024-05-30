namespace DriveEase.Infrastructure.Persistance.Configurations
{
	public class RentalRateConfiguration : IEntityTypeConfiguration<RentalRate>
	{
		public void Configure(EntityTypeBuilder<RentalRate> builder)
		{
			builder.ToTable("RentalRates");
		}
	}
}
