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

        //public List<Adress> Adresses { get; set; }

        public Customer()
        {
        }

        public Customer(int id, string companyName, Person person, int? phone)
        {
            Id = id;
            CompanyName = companyName;
            Person = person;
            Phone = phone;
        }
    }
}
