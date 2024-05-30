namespace DriveEase.Infrastructure.Persistance.Configurations
{
	public class NotificationConfiguration : IEntityTypeConfiguration<Notification>
	{
		public void Configure(EntityTypeBuilder<Notification> builder)
		{
			builder.ToTable("Notifications");

			builder.Property(e => e.ClientId).IsRequired();
			builder.Property(e => e.Message).HasMaxLength(200);

			builder.HasOne(e => e.Client)
				.WithMany(e => e.Notifications)
				.HasForeignKey(e => e.ClientId)
				.OnDelete(DeleteBehavior.Cascade); // Usunięcie użytkownika skutkuje usunięciem powiadomień
		}
	}
}
