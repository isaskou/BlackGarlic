using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using dal = BlackGarlic.DAL.Models.Panier;
using dto = BlackGarlic.DTO.Models.Caddies;


namespace BlackGarlic.DTO.Tools.CaddieMapper
{
    public static class CommandProductMapper
    {
        public static dal.CommandProduct toDTO(this dto.CommandProduct cp)
        {
            if (cp == null) return null;
            return new dal.CommandProduct()
            {
                Id = cp.Id,
                CommandId = cp.CommandId,
                ProductId = cp.ProductId,
                Quantity = cp.Quantity
            };
        }

        public static dto.CommandProduct toDAL(this dal.CommandProduct cp)
        {
            if (cp == null) return null;
            return new dto.CommandProduct()
            {
                Id = cp.Id,
                CommandId = cp.CommandId,
                ProductId = cp.ProductId,
                Quantity = cp.Quantity
            };
        }
    }
}
