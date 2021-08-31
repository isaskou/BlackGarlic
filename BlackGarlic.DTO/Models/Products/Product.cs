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
        public string Utilisation { get; set; }
        public string Ingredients { get; set; }

        public bool IsDisabled { get; set; }
        public decimal UnitPrice { get; set; }

        public int CategoryId { get; set; }

        public CategoryProduct Category { get; set; }

        //public int ProviderId { get; set; }
        //public Provider Provider { get; set; }
        public string PictureUrl { get; set; }

        public Product()
        {
        }

        public Product(int id, string name, string description, string utilisation, string ingredients, bool isDisabled, decimal unitPrice, int categoryId, string pictureUrl)
        {
            Id = id;
            Name = name;
            Description = description;
            Utilisation = utilisation;
            Ingredients = ingredients;
            IsDisabled = isDisabled;
            UnitPrice = unitPrice;
            CategoryId = categoryId;
            PictureUrl = pictureUrl;
        }
    }
}
