using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGarlic.DTO.Models.People
{
    public class Customer
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }

        public int PersonId { get; set; }
        public Person Person { get; set; }
        public int? Phone { get; set; }

        public int AdressId { get; set; }
        public CustomerAdress CustomerAdress { get; set; }

        //public List<Adress> Adresses { get; set; }

        public Customer()
        {
        }

        public Customer(int id, string companyName, int personId, Person person, int? phone, int adressId, CustomerAdress customerAdress)
        {
            Id = id;
            CompanyName = companyName;
            PersonId = personId;
            Person = person;
            Phone = phone;
            AdressId = adressId;
            CustomerAdress = customerAdress;
        }
    }
}
