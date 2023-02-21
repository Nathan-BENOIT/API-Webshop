using System;

namespace APIWebshop
{
	public class Order
	{
		public DateTime CreatedAt { get; set; }
		public String? Id { get; set; }
		public String? CustomerId { get; set; }

		public Order()
		{
		}

		public Order(DateTime createdAt, string id, string customerId)
		{
			CreatedAt = createdAt;
			Id = id;
			CustomerId = customerId;
		}
	}
}

