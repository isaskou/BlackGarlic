using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dto = BlackGarlic.DTO.Models.People;
using dal = BlackGarlic.DAL.Models.People;

namespace BlackGarlic.DTO.Tools.PeopleMapper
{
    public static class CustomerMapper
    {
        public static dto.Customer toDAL(this dal.Customer c)
        {
            return new dto.Customer
            {
                Id = c.Id,
                FirstName = c.FirstName,
                LastName = c.LastName,
                Phone = c.Phone,
                Email = c.Email,
                RoleId = c.RoleId,
                CompanyName = c.CompanyName
            };
        }

        public static dal.Customer toDTO(this dto.Customer c)
        {
            return new dal.Customer
            {
                Id = c.Id,
                FirstName = c.FirstName,
                LastName = c.LastName,
                Phone = c.Phone,
                Email = c.Email,
                RoleId = c.RoleId,
                CompanyName = c.CompanyName,
                Password = c.Password
            };


        }
    }
}
