namespace DriveEase.Infrastructure.Persistance.Configurations
{
	public class ReviewConfiguration : IEntityTypeConfiguration<Review>
	{
		public void Configure(EntityTypeBuilder<Review> builder)
		{
			builder.ToTable("Reviews");

			builder.Property(e => e.Rating).IsRequired();
			builder.Property(e => e.Comment).IsRequired();
			builder.Property(e => e.DatePosted).IsRequired();

			builder.HasOne(e => e.Rental)
				.WithMany(e => e.Reviews)
				.HasForeignKey(e => e.RentalId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.HasOne(e => e.Client)
				.WithMany(e => e.Reviews)
				.HasForeignKey(e => e.ClientId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
