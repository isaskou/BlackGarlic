using BlackGarlic.DTO.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGarlic.DTO.Models.Caddies
{
    public class CaddieLine
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public TVAAmount TVAAmount { get; set; }
        public double SubTotal { get; set; }
        public Caddie Caddie { get; set; }

        public CaddieLine()
        {

        }

        public CaddieLine(int id, Product product, int quantity, TVAAmount tVAAmount, double subTotal, Caddie caddie)
        {
            Id = id;
            Product = product;
            Quantity = quantity;
            TVAAmount = tVAAmount;
            SubTotal = subTotal;
            Caddie = caddie;
        }
    }
}
