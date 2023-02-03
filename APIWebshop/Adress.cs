using System;
namespace APIWebshop
{
	public class Adress
	{

		public int CodePostal { get; set; }
		public String? Ville { get; set; }

		public Adress()
		{
		}

		public Adress(int codePostal, String ville)
		{
			CodePostal = codePostal;
			Ville = ville;
		}
	}
}

