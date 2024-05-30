namespace DriveEase.Infrastructure.Persistance.Configurations
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Cars");

            builder.Property(e => e.Brand).IsRequired().HasMaxLength(50);
            builder.Property(e => e.Model).IsRequired().HasMaxLength(50);
            builder.Property(e => e.Year).IsRequired();
            builder.Property(e => e.LicensePlate).IsRequired().HasMaxLength(10);
            builder.Property(e => e.LocationGPS).HasMaxLength(50);
            builder.Property(e => e.ImageURL).HasMaxLength(255);
            builder.Property(e => e.LogoURL).HasMaxLength(255);
            builder.Property(e => e.VinNumber).IsRequired().HasMaxLength(50);
            builder.Property(e => e.Color).HasMaxLength(50);
            builder.Property(e => e.Mileage).HasMaxLength(50);
            builder.Property(e => e.FuelType).HasMaxLength(50);
            builder.Property(e => e.Transmission).HasMaxLength(50);
            builder.Property(e => e.Engine).HasMaxLength(50);
            builder.Property(e => e.InsurancePolicyNumber).IsRequired().HasMaxLength(50);
            builder.Property(e => e.Power).HasMaxLength(10);

            builder.HasMany(e => e.Rentals)
                .WithOne(e => e.Car)
                .HasForeignKey(e => e.CarId)
                .OnDelete(DeleteBehavior.Restrict); // Usunięcie samochodu nie powinno skutkować usunięciem wypożyczenia

            builder.HasMany(e => e.Reservations)
                .WithOne(e => e.Car)
                .HasForeignKey(e => e.CarId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(e => e.ServiceHistory)
                .WithOne(e => e.Car)
                .HasForeignKey(e => e.CarId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(e => e.RentalRates)
                .WithOne(e => e.Car)
                .HasForeignKey(e => e.CarId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(e => e.LicensePlate).IsUnique();
            builder.HasIndex(e => e.VinNumber).IsUnique();
        }
    }
}
