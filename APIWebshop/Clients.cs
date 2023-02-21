using System;

namespace APIWebshop
{
    public class Clients
    {
        public DateTime CreatedAt { get; set; }
        public String? Name { get; set; }
        public String? Username { get; set; }
        public String? FirstName { get; set; }
        public String? LastName { get; set; }
        public Address? Address { get; set; }
        public Profile? Profile { get; set; }
        public Company? Company { get; set; }
        public int Id { get; set; }

        public Clients()
        {
        }

        public Clients(DateTime createdAt, string name, string username, string firstname, string lastname, Address address, Profile profile,
            Company company, int id)
        {
            CreatedAt = createdAt;
            Name = name;
            Username = username;
            FirstName = firstname;
            LastName = lastname;
            Address = address;
            Profile = profile;
            Company = company;
            Id = id;
        }
    }
}
