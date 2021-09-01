using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using dto = BlackGarlic.DTO.Models.Products;
using dal = BlackGarlic.DAL.Models.Products;


namespace BlackGarlic.DTO.Tools.ProductsMapper
{
    public static class CategoryProductMapper
    {
        public static dto.CategoryProduct toDAL(this dal.CategoryProduct cp)
        {
            return new dto.CategoryProduct
            {
                Id = cp.Id,
                Name = cp.Name,
                Description = cp.Description
            };
        }

        public static dal.CategoryProduct toDTO(this dto.CategoryProduct cp)
        {
            return new dal.CategoryProduct
            {
                Id = cp.Id,
                Name = cp.Name,
                Description = cp.Description
            };
        }
    }
}
