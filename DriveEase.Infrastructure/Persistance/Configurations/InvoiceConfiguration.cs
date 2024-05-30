namespace DriveEase.Infrastructure.Persistance.Configurations
{
	public class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
	{
		public void Configure(EntityTypeBuilder<Invoice> builder)
		{
			builder.ToTable("Invoices");

			builder.Property(e => e.MethodOfPayment).IsRequired().HasMaxLength(20);
			builder.Property(e => e.RentalId).IsRequired();
			builder.Property(e => e.ClientId).IsRequired();

			builder.HasOne(e => e.Client)
				.WithMany(e => e.Invoices)
				.HasForeignKey(e => e.ClientId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.HasOne(e => e.Rental)
				.WithOne(e => e.Invoice)
				.HasForeignKey<Invoice>(e => e.RentalId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
