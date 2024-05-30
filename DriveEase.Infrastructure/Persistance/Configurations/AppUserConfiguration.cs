namespace DriveEase.Infrastructure.Persistance.Configurations
{
	public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
	{
		public void Configure(EntityTypeBuilder<AppUser> builder)
		{
			builder.Property(e => e.Email).IsRequired();
			builder.Property(e => e.UserName).IsRequired();

			builder.Property(e => e.FirstName).IsRequired().HasMaxLength(50);
			builder.Property(e => e.LastName).IsRequired().HasMaxLength(50);
			builder.Property(e => e.DateOfBirth).IsRequired();

			builder.HasOne(e => e.Address)
				.WithOne(e => e.AppUser)
				.HasForeignKey<Address>(e => e.UserId);

			builder.HasMany(e => e.Employees)
				.WithOne(e => e.AppUser)
				.OnDelete(DeleteBehavior.Restrict);  // Aby uniknąć usunięcia użytkownika w przypadku usunięcia pracownika

			builder.HasMany(e => e.Clients)
				.WithOne(e => e.AppUser)
				.OnDelete(DeleteBehavior.Restrict); // Podobnie, aby zabezpieczyć dane użytkownika
		}
	}
}
