using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dto = BlackGarlic.DTO.Models.People;
using dal = BlackGarlic.DAL.Models.People;

namespace BlackGarlic.DTO.Tools.PeopleMapper
{
    public static class CustomerAdressMapper
    {
        public static dto.CustomerAdress toDAL(this dal.CustomerAdress ca)
        {
            return new dto.CustomerAdress
            {
                Id = ca.Id,
                CustomerId = ca.CustomerId,
                AdressId = ca.AdressId
            };
        }

        public static dal.CustomerAdress toDTO(this dto.CustomerAdress ca)
        {
            return new dal.CustomerAdress
            {
                Id = ca.Id,
                CustomerId = ca.CustomerId,
                AdressId = ca.AdressId
            };
        }

    }
}
