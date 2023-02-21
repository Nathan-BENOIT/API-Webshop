using System;
namespace APIWebshop
{
	public class Address
	{

		public String? PostalCode { get; set; }
		public String? City { get; set; }

		public Address()
		{
		}

		public Address(string postalCode, string city)
		{
            PostalCode = postalCode;
            City = city;
		}
	}
}

