namespace DriveEase.Infrastructure.Persistance.Configurations
{
	public class ServiceHistoryConfiguration : IEntityTypeConfiguration<ServiceHistory>
	{
		public void Configure(EntityTypeBuilder<ServiceHistory> builder)
		{
			builder.ToTable("ServiceHistory");

			builder.Property(e => e.ServiceDate).IsRequired();
			builder.Property(e => e.ServiceType).IsRequired().HasMaxLength(200);
			builder.Property(e => e.Description).HasMaxLength(500);
			builder.Property(e => e.Cost).IsRequired();
			builder.Property(e => e.ServiceProvider).HasMaxLength(100);
			builder.Property(e => e.Notes).HasMaxLength(500);

			builder.HasOne(s => s.Car)
				   .WithMany(c => c.ServiceHistory)
				   .HasForeignKey(s => s.CarId)
				   .OnDelete(DeleteBehavior.Restrict);

			builder.HasIndex(s => s.ServiceDate);
			builder.HasIndex(s => s.CarId);
		}
	}
}
