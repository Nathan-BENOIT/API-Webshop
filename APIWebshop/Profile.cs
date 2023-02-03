using System;
namespace APIWebshop
{
	public class Profile
	{

		public String? FirstName { get; set; }
		public String? LastName { get; set; }

		public Profile()
		{
		}

		public Profile(String firstName, String lastName)
		{
            FirstName = firstName;
            LastName = lastName;
		}
	}
}

