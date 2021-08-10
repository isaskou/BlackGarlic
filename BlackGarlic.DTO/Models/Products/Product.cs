using BlackGarlic.DTO.Models.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGarlic.DTO.Models.Products
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsDisabled { get; set; }
        public double UnitPrice { get; set; }
        public List<CategoryProduct> Categories { get; set; }
        public Provider Provider { get; set; }
        public string PictureUrl { get; set; }

        public Product()
        {
        }

    }
}
