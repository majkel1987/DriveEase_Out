﻿using DriveEase.Domain.Enums;

namespace DriveEase.Shared.CarServices.Dtos
{
	public class ServiceHistoryDto
	{
		public int Id { get; set; }
		public DateTime ServiceDate { get; set; }
		public DateTime? ServiceEndDate { get; set; }
		public string ServiceType { get; set; }
		public string Description { get; set; }
		public decimal Cost { get; set; }
		public string ServiceProvider { get; set; }
		public string Notes { get; set; }
		public bool IsFinished { get; set; }
		public bool IsDeleted { get; set; }
		public ServiceStatus Status { get; set; }
		public int CarId { get; set; }
	}
}
