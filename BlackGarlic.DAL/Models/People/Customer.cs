using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGarlic.DAL.Models.People
{
    public class Customer
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public int PersonId { get; set; }
        public int? Phone { get; set; }

        public Person Person { get; set; }
    }
}
