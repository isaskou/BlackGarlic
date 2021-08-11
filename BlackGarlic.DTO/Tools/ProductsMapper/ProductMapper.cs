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
        public static dto.Product toDTO(this dal.Product p)
        {
            return new dto.Product
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                IsDisabled = p.IsDisabled,
                UnitPrice = p.UnitPrice,
                PictureUrl = p.PictureUrl
            };
        }

        public static dal.Product toDAL(this dto.Product p)
        {
            if (p == null) return null;
            return new dal.Product
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                IsDisabled = p.IsDisabled,
                UnitPrice = p.UnitPrice,
                CategoryProductId = p.CategoryId,
                ProviderId = p.ProviderId,
                PictureUrl = p.PictureUrl
            };
        }
    }
}
