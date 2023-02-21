using System;

namespace APIWebshop
{
	public class Order
	{
		public DateTime Date { get; set; }
		public string? Id { get; set; }
		public string? CustomerId { get; set; }

		public Order()
		{
		}

		public Order(DateTime date, string id, string customerId)
		{
			Date = date;
			Id = id;
			CustomerId = customerId;
		}
	}
}

