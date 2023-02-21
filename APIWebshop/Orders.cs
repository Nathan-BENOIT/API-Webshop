using System;
namespace APIWebshop
{
	public class Orders
	{
		public Order[]? OrdersArray { get; set; }

		public Orders()
		{
		}

		public Orders(Order[] ordersArray)
		{
            OrdersArray = ordersArray;
		}
	}
}

