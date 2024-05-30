namespace DriveEase.Infrastructure.Persistance.Configurations
{
	public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
	{
		public void Configure(EntityTypeBuilder<Employee> builder)
		{
			builder.ToTable("Employees");

			builder.Property(e => e.FirstName).IsRequired().HasMaxLength(50);
			builder.Property(e => e.LastName).HasMaxLength(50);
			builder.Property(e => e.ImageUrl).HasMaxLength(500);
			builder.Property(e => e.UserId).IsRequired();

			builder.HasOne(e => e.AppUser)
				.WithMany(u => u.Employees)
				.HasForeignKey(e => e.UserId)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
