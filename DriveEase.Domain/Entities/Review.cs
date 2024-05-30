﻿namespace DriveEase.Domain.Entities
{
	public class Review
	{
		public int Id { get; set; }
		public int Rating { get; set; }
		public string Comment { get; set; }
		public DateTime DatePosted { get; set; }
		public int RentalId { get; set; }
		public Rental Rental { get; set; }
		public int ClientId { get; set; }
		public Client Client { get; set; }
	}
}
