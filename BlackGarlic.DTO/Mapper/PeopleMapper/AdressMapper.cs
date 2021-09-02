using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dto = BlackGarlic.DTO.Models.People;
using dal = BlackGarlic.DAL.Models.People;

namespace BlackGarlic.DTO.Tools.PeopleMapper
{
    public static class AdressMapper
    {
        public static dto.Adress toDAL(this dal.Adress a)
        {
            return new dto.Adress()
            {
                Id = a.Id,
                Street = a.Street,
                Number = a.Num,
                PostalCode = a.PostalCode,
                City = a.City,
                District = a.District
            };
        }

        public static dal.Adress toDTO(this dto.Adress a)
        {
            return new dal.Adress
            {
                Id = a.Id,
                Street = a.Street,
                Num = a.Number,
                PostalCode = a.PostalCode,
                City = a.City,
                District = a.District
            };
        }

    }
}
