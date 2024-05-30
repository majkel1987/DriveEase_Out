namespace DriveEase.Infrastructure.Persistance.Configurations
{
	public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
	{
		public void Configure(EntityTypeBuilder<Reservation> builder)
		{
			builder.ToTable("Reservations");

			builder.Property(e => e.StartDate).IsRequired();
			builder.Property(e => e.EndDate).IsRequired();
			builder.Property(e => e.Status).IsRequired();

			builder.HasOne(e => e.Car)
				.WithMany(e => e.Reservations)
				.HasForeignKey(e => e.CarId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.HasOne(e => e.Client)
				.WithMany(e => e.Reservations)
				.HasForeignKey(e => e.ClientId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
