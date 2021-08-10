using BlackGarlic.DAL.Models.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGarlic.DAL.Models.Panier
{
    public class Caddie
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int? ShipAmountId { get; set; }
        public ShipAmount? ShipAmount { get; set; }
        public double TotalCaddie { get; set; }
    }
}
