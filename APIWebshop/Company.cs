using System;

namespace APIWebshop
{
    public class Company
    {
        public String? CompanyName { get; set; }

        public Company()
        {
        }

        public Company(string companyName)
        {
            CompanyName = companyName;            
        }
    }
}
