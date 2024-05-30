namespace DriveEase.Infrastructure.Persistance.Configurations
{
	public class RentalConfiguration : IEntityTypeConfiguration<Rental>
	{
		public void Configure(EntityTypeBuilder<Rental> builder)
		{
			builder.ToTable("Rentals");

			builder.Property(e => e.StartDate).IsRequired();
			builder.Property(e => e.EndDate).IsRequired();
			builder.Property(e => e.TotalPrice).IsRequired();

			builder.HasOne(e => e.Car)
				.WithMany(e => e.Rentals)
				.HasForeignKey(e => e.CarId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.HasOne(e => e.Client)
				.WithMany(e => e.Rentals)
				.HasForeignKey(e => e.ClientId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.HasOne(e => e.Invoice)
				.WithOne(e => e.Rental)
				.HasForeignKey<Rental>(e => e.InvoiceId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
