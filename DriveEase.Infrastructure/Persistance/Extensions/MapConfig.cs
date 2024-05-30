using DriveEase.Shared.CarServices.Dtos;

namespace DriveEase.Infrastructure.Persistance.Extensions
{
	public static class MapConfig
	{
		public static void RegisterServiceHistoryMapping()
		{
			TypeAdapterConfig<Car, CarDto>.NewConfig()
				.Map(dest => dest.ServiceHistory, src => src.ServiceHistory.Select(sh => new ServiceHistoryDto
				{
					Id = sh.Id,
					ServiceDate = sh.ServiceDate,
					ServiceEndDate = sh.ServiceEndDate,
					ServiceType = sh.ServiceType,
					Description = sh.Description,
					Cost = sh.Cost,
					ServiceProvider = sh.ServiceProvider,
					Notes = sh.Notes,
					IsFinished = sh.IsFinished,
					Status = sh.Status,
					CarId = sh.CarId
				}));
		}
	}
}
