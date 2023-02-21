using System;
namespace APIWebshop
{
	public class Products
	{
		public DateTime CreatedAt { get; set; }
		public String? Name { get; set; }
		public Details? Details { get; set; }
		public int Stock { get; set; }
		public int Id { get; set; }
		public int OrderId { get; set; }

		public Products()
		{
		}

		public Products(DateTime createdAt, string name, Details details, int stock, int id, int orderId)
		{
			CreatedAt = createdAt;
			Name = name;
			Details = details;
			Stock = stock;
			Id = id;
			OrderId = orderId;
		}
	}
}

