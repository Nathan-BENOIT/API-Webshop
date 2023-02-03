using System;

namespace APIWebshop
{
    public class Clients
    {
        public DateTime Date { get; set; }
        public String? Name { get; set; }
        public String? Username { get; set; }
        public String? FirstName { get; set; }
        public String? LastName { get; set; }
        public Adress? Adress { get; set; }
        public Profile? Profile { get; set; }
        public Company? Company { get; set; }
        public Orders? Orders { get; set; }
        public int Stock { get; set; }
        public int Id { get; set; }

        public Produits()
        {
        }

        public Produits(DateTime date, string name)
        {
            Date = date;
            Name = name;
            
        }
    }
}
