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
        public int Id { get; set; }
        public Orders? Orders { get; set; }

        public Clients()
        {
        }

        public Clients(DateTime date, string name, string username, string firstname, string lastname, Adress adress, Profile profile,
            Company company, int id, Orders orders, int stock)
        {
            Date = date;
            Name = name;
            Username = username;
            FirstName = firstname;
            LastName = lastname;
            Adress = adress;
            Profile = profile;
            Company = company;
            Id = id;
            Orders = orders;
        }
    }
}
