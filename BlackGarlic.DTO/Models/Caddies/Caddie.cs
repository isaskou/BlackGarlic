using BlackGarlic.DTO.Models.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGarlic.DTO.Models.Caddies
{
    public class Caddie
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public Customer Customer { get; set; }
        public ShipAmount ShipAmount { get; set; }
        public double TotalCaddie { get; set; }

        public Caddie()
        {

        }

        public Caddie(int id, DateTime orderDate, Customer customer, ShipAmount shipAmount, double totalCaddie)
        {
            Id = id;
            OrderDate = orderDate;
            Customer = customer;
            ShipAmount = shipAmount;
            TotalCaddie = totalCaddie;
        }
    }
}
