using DriveEase.Domain.Enums;

namespace DriveEase.Domain.Entities
{
    public class Notification
	{
		public int Id { get; set; }
		public string Message { get; set; }
		public DateTime Date { get; set; }
		public NotificationStatus Status { get; set; }
		public int ClientId { get; set; }
		public Client Client { get; set; }
	}
}
