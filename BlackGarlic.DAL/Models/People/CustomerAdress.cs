using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGarlic.DAL.Models.People
{
    public class CustomerAdress
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int AdressId { get; set; }
    }
}
