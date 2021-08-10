using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGarlic.DAL.Models.People
{
    public class Adress
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string Num { get; set; }
        public int PostalCode { get; set; }
        public string City { get; set; }
        public string District { get; set; }
    }
}
