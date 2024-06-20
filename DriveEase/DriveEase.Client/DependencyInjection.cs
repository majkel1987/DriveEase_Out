using DriveEase.Client.HttpRepository;
using DriveEase.Client.HttpRepository.Interfaces;
using Radzen;

namespace DriveEase.Client
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddClient(this IServiceCollection services, Uri uri)
		{
			services.AddHttpClient("DriveEase.WebAPI", client =>
			{
				client.BaseAddress = uri;
				client.Timeout = TimeSpan.FromMinutes(5);
			});

			services.AddScoped(sp => sp.GetService<IHttpClientFactory>().CreateClient("DriveEase.WebAPI"));

			services.AddRadzenComponents();
			services.AddScoped<ICarHttpRepository, CarHttpRepository>();
			services.AddScoped<IServiceHttpRepository, ServiceHttpRepository>();
			services.AddScoped<IClientHttpRepository, ClientHttpRepository>();

			return services;
		}
	}
}
