using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dto = BlackGarlic.DTO.Models.People;
using dal = BlackGarlic.DAL.Models.People;

namespace BlackGarlic.DTO.Tools.PeopleMapper
{
    public static class RoleMapper
    {
        public static dto.Role toDAL(this dal.Role r)
        {
            return new dto.Role()
            {
                Id = r.Id,
                Name = r.Name
            };
        }

        public static dal.Role toDTO(this dto.Role r)
        {
            return new dal.Role()
            {
                Id = r.Id,
                Name = r.Name
            };
        }
    }
}
