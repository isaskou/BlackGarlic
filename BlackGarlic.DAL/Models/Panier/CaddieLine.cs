using BlackGarlic.DAL.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGarlic.DAL.Models.Panier
{
    public class CaddieLine
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public int TVAAmountId { get; set; }
        public TVAAmount TVAAmount { get; set; }
        public double SubTotal { get; set; }
        public int CaddieId { get; set; }
        public Caddie Caddie { get; set; }
    }
}
