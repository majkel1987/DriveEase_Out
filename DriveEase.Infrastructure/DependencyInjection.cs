using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server;
using Microsoft.AspNetCore.Identity;

namespace DriveEase.Infrastructure
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddScoped<IApplicationDbContext, ApplicationDbContext>();
			services.AddScoped<ICarService, CarService>();
			services.AddScoped<IClientService, ClientService>();
			services.AddScoped<IServiceHistoryService, ServiceHistoryService>();

			var connectionString = configuration.GetConnectionString("DefaultConnection");

			services.AddDbContext<ApplicationDbContext>(options =>
			   options.UseSqlServer(connectionString)
			   .EnableSensitiveDataLogging());

			AddAuthentication(services);

			MapConfig.RegisterServiceHistoryMapping();

			return services;
		}

		public static void AddAuthentication(IServiceCollection services)
		{
			services.AddScoped<IAuthenticationService, AuthenticationService>();
			services.AddScoped<AuthenticationStateProvider, ServerAuthenticationStateProvider>();
			services.AddCascadingAuthenticationState();
			services.AddAuthorization();
			services.AddAuthentication(options =>
			{
				options.DefaultScheme = IdentityConstants.ApplicationScheme;
				options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
			})
				.AddIdentityCookies();

			services.AddIdentityCore<AppUser>(options =>
			{
				options.SignIn.RequireConfirmedAccount = true;
			})
				.AddEntityFrameworkStores<ApplicationDbContext>()
				.AddSignInManager()
				.AddDefaultTokenProviders();
		}
	}
}
