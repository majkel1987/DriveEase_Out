using DriveEase.Client.HttpRepository;
using DriveEase.Client.HttpRepository.Interfaces;

namespace DriveEase.Client
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddClient(this IServiceCollection services, Uri uri)
		{
			services.AddHttpClient("DriveEaseAPI", client =>
			{
				client.BaseAddress = uri;
				client.Timeout = TimeSpan.FromMinutes(5);
			});

			services.AddScoped(sp =>
				sp.GetService<IHttpClientFactory>().CreateClient("DriveEaseAPI"));

			services.AddScoped<ICarRepository, CarRepository>();

			return services;
		}

	}
}
