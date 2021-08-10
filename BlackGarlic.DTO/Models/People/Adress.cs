using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGarlic.DTO.Models.People
{
    public class Adress
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public int PostalCode { get; set; }
        public string City { get; set; }
        public string District { get; set; }

        public Adress()
        {
        }

        public Adress(int id, string street, string number, int postalCode, string city, string district)
        {
            Id = id;
            Street = street;
            Number = number;
            PostalCode = postalCode;
            City = city;
            District = district;
        }
    }
}
