using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGarlic.DTO.Models.People
{
    public class Provider
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public int? PhoneNumber { get; set; }
        public int? AdressId { get; set; }

        public Provider()
        {
        }

        public Provider(int id, string firstName, string lastName, string companyName, int? phoneNumber, int? adressId)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            CompanyName = companyName;
            PhoneNumber = phoneNumber;
            AdressId = adressId;
        }
    }
}
