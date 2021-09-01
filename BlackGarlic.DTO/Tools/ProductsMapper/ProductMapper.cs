using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using dto = BlackGarlic.DTO.Models.Products;
using dal = BlackGarlic.DAL.Models.Products;

namespace BlackGarlic.DTO.Tools.ProductsMapper
{
    public static class ProductMapper
    {
        public static dto.Product toDAL(this dal.Product p)
        {
            return new dto.Product
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                Utilisation = p.Utilisation,
                Ingredients = p.Ingredients,
                IsDisabled = p.IsDisabled,
                UnitPrice = p.UnitPrice,
                CategoryId=p.CategoryProductId,
                PictureUrl = p.PictureUrl
            };
        }

        public static dal.Product toDTO(this dto.Product p)
        {
            if (p == null) return null;
            return new dal.Product
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                Utilisation = p.Utilisation,
                Ingredients = p.Ingredients,
                IsDisabled = p.IsDisabled,
                UnitPrice = p.UnitPrice,
                CategoryProductId = p.CategoryId,
                //ProviderId = p.ProviderId,
                PictureUrl = p.PictureUrl
            };
        }
    }
}
