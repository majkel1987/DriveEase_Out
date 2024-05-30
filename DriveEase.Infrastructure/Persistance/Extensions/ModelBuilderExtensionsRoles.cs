using Microsoft.AspNetCore.Identity;

namespace DriveEase.Infrastructure.Persistance.Extensions
{
	static class ModelBuilderExtensionsRoles
	{
		public static void SeedRoles(this ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<IdentityRole>().HasData(
				new IdentityRole
				{
					Id = "378BB303-1042-436F-9A0D-808F9BE41B09",
					Name = "Admin",
					NormalizedName = "ADMIN",
					ConcurrencyStamp = "378BB303-1042-436F-9A0D-808F9BE41B08"
				},
				new IdentityRole
				{
					Id = "99C16AF4-43E2-4C22-9972-847D990F4228",
					Name = "Manager",
					NormalizedName = "MANAGER",
					ConcurrencyStamp = "99C16AF4-43E2-4C22-9972-847D990F4227"
				},
				new IdentityRole
				{
					Id = "F64DDDCB-E4FC-4EFA-92C3-81C1AC808927",
					Name = "Employee",
					NormalizedName = "EMPLOYEE",
					ConcurrencyStamp = "F64DDDCB-E4FC-4EFA-92C3-81C1AC808926"
				},
				new IdentityRole
				{
					Id = "F0B78148-B1FF-4E40-A791-1DDCC28E90F6",
					Name = "Client",
					NormalizedName = "CLIENT",
					ConcurrencyStamp = "F0B78148-B1FF-4E40-A791-1DDCC28E90F5"
				});
		}
	}
}
