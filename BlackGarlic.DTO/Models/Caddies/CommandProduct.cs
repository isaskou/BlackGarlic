using BlackGarlic.DTO.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGarlic.DTO.Models.Caddies
{
    public class CommandProduct
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public int CommandId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }

    }
}
