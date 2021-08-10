using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGarlic.DAL.Models.People
{
    public class Provider
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public int? PhoneNumber { get; set; }
        public int? AdressId { get; set; }


        public Adress Adress { get; set; }
    }
}
