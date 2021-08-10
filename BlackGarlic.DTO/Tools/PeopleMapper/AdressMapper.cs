using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGarlic.DTO.Tools.PeopleMapper
{
    public static class AdressMapper
    {
        public static DTO.Models.People.Adress toDTO(this DAL.Models.People.Adress a)
        {
            return new DTO.Models.People.Adress(a.Id, a.Street, a.Num, a.PostalCode, a.City, a.District);
        }

        public static DAL.Models.People.Adress toDAL(this DTO.Models.People.Adress a)
        {
            return new DAL.Models.People.Adress
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
