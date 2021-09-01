using BlackGarlic.DTO.Models.Caddies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dal = BlackGarlic.DAL.Models.Panier;
using dto=BlackGarlic.DTO.Models.Caddies;

namespace BlackGarlic.DTO.Tools.CaddieMapper
{
    public static class CommandMapper
    {
        public static dal.Command toDTO(this dto.Command command)
        {
            if (command!= null)
            {
                return new dal.Command()
                {
                    Id = command.Id,
                    DateOfCommand = DateTime.Now,
                    CustomerId = command.CustomerId,
                    CustommerAdressId = command.CustommerAdressId

                };
            }
            return null;
        }

        public static dto.Command toDAL(this dal.Command c)
        {
            if(c != null)
            {
                return new dto.Command(c.Id, c.DateOfCommand, c.CustomerId, c.CustommerAdressId, new List<CommandProduct>());
            }
            return null;
        }
    }
}
