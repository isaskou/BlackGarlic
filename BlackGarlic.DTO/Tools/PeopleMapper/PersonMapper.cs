using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using dal = BlackGarlic.DAL.Models.People;
using dto = BlackGarlic.DTO.Models.People;

namespace BlackGarlic.DTO.Tools.PeopleMapper
{
    public static class PersonMapper
    {
        public static dto.Person toDTO(this dal.Person p)
        {
            return new dto.Person
            {
                Id = p.Id,
                FirstName = p.FirstName,
                LastName = p.LastName,
                Email = p.Email,
                Password = p.Password,
                RoleId = p.RoleId
            };
        }

        public static dal.Person toDAL(this dto.Person p)
        {
            return new dal.Person
            {
                Id = p.Id,
                FirstName = p.FirstName,
                LastName = p.LastName,
                Email = p.Email,
                Password = p.Password,
                RoleId = p.RoleId
            };
        }
    }
}
